using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using AgWebScanner.Controls;
using AgWebScanner.Core;
using AgWebScanner.Core.Scanner;

namespace AgWebScanner
{
	public partial class FmScanner : Form
	{
		#region Fields

		private ScannerManager _scannerManager;
		private readonly SettingsManager _settingsManager;
		private List< ScannerSetting > _settingsToCheck;
		private string _cachedFilesFolder;
		private ListSortDirection _currentSortDirection = ListSortDirection.Ascending;

		#endregion Fields

		#region Constructors

		public FmScanner()
		{
			this._settingsManager = new SettingsManager();
			this.InitializeComponent();
			this.InitializeMembers();
		}

		#endregion Constructors

		#region Methods

		private void InitializeMembers()
		{
			this.pageVpnScan.Controls.Add( new ucVpnScan() );
			this.pageUnEnumerator.Controls.Add( new ucUsernameEnumerator() );
            this.pageHTTPScan.Controls.Add(new ucHttpScan());
			this.btnStop.Enabled = false;
			this.btnStopDirScan.Enabled = false;
			this.BindControls();

			this.bgWorker.DoWork += this.BgWorkerDoWork;
			this.bgWorker.RunWorkerCompleted += this.BgWorkerRunWorkerCompleted;
			this.bgWorker.WorkerReportsProgress = true;
			this.bgWorker.WorkerSupportsCancellation = true;

			this.bgDirectoryWorker.DoWork += this.bgDirectoryWorker_DoWork;
			this.bgDirectoryWorker.RunWorkerCompleted += this.bgDirectoryWorker_RunWorkerCompleted;
			this.bgDirectoryWorker.WorkerReportsProgress = true;
			this.bgDirectoryWorker.WorkerSupportsCancellation = true;

			this.bgQuickWorker.DoWork += bgQuickWorker_DoWork;
			this.bgQuickWorker.RunWorkerCompleted += bgQuickWorker_RunWorkerCompleted;
			this.bgQuickWorker.WorkerReportsProgress = true;
			this.bgQuickWorker.WorkerSupportsCancellation = true;

			this.gvResults.DataBindingComplete += this.gvResults_DataBindingComplete;
			this.gvResults.CellMouseMove += this.gvResults_CellMouseMove;
		}

		private void BindControls()
		{
			var dataSource = this._settingsManager.GetSettings();

			if( dataSource.Count == 0 )
			{
				return;
			}

			this.chbListExistingChecks.DataSource = dataSource.Where( x => !x.DirCheck ).ToList();
			this.chbListExistingChecks.DisplayMember = "CheckName";

			this.chblExistingDirScans.DataSource = dataSource.Where( x => x.DirCheck ).ToList();
			this.chblExistingDirScans.DisplayMember = "CheckName";

			this.cbAvailableChecks.DisplayMember = "CheckName";

			dataSource.Add( new ScannerSetting() );

			this.cbAvailableChecks.DataSource = dataSource;
			this.cbAvailableChecks.ValueMember = "CheckName";
			this.cbAvailableChecks.DisplayMember = "CheckName";
			this.cbAvailableChecks.DropDownStyle = ComboBoxStyle.DropDownList;
			this.cbAvailableChecks.SelectedIndex = dataSource.Count - 1;

			this.cbChecksForDelete.DataSource = dataSource;
			this.cbChecksForDelete.ValueMember = "CheckName";
			this.cbChecksForDelete.DisplayMember = "CheckName";
			this.cbChecksForDelete.DropDownStyle = ComboBoxStyle.DropDownList;
			this.cbChecksForDelete.SelectedIndex = dataSource.Count - 1;
		}

		private void ExtractSelectedChecks( bool fileCheck )
		{
			this._settingsToCheck = new List< ScannerSetting >();
			CheckedListBox.CheckedItemCollection checks = fileCheck
			                                              	? this.chbListExistingChecks.CheckedItems
			                                              	: this.chblExistingDirScans.CheckedItems;

			foreach( var item in checks )
			{
				var setting = ( ScannerSetting )item;

				if( !String.IsNullOrEmpty( this.tbVirtualFolder.Text ) )
				{
					setting.Folder = this.tbVirtualFolder.Text;
				}

				this._settingsToCheck.Add( setting );
			}
		}

		private void DisableControls( Control.ControlCollection controls, bool state )
		{
			foreach( Control control in controls )
			{
				if( control is TabControl )
				{
					foreach( var nested in ( ( TabControl )control ).Controls )
					{
						if( ( nested is TabPage ) && ( ( TabPage )nested ).Text.Equals( "Settings" ) )
						{
							( ( Control )nested ).Enabled = state;
						}
						else if( nested is TabPage )
						{
							this.DisableControls( ( ( Control )nested ).Controls, state );
						}
					}
				}
				else if( control is GroupBox )
				{
					this.DisableControls( control.Controls, state );
				}
				else if( !( control is StatusStrip ) )
				{
					( ( Control )control ).Enabled = state;
				}
			}

			this.btnStop.Enabled = !state;
			this.btnStopDirScan.Enabled = !state;
			this.btnQuickStop.Enabled = !state;
		}

		private void ClearSettings()
		{
			this.rtbAddFileName.Text = String.Empty;
			this.rtbAddFilePath.Text = String.Empty;
			this.rtbEditFilePath.Text = String.Empty;
			this.tbIbmFile.Text = String.Empty;
			this.tbWebLogin.Text = String.Empty;
			this.tbWebPassword.Text = String.Empty;
			this.chbIbmEnabled.Checked = false;

            GroupBox ff = null;

            foreach (var control in this.tpResponseTypes.Controls)
            {
                if (control is GroupBox)
                {
                    if (((GroupBox)control).Name == "groupBox16")
                        ff = (GroupBox)control;
                }
            }
            if (ff != null)
                foreach (var control in ff.Controls)
                {
                    if (control is CheckBox)
                    {
                        ((CheckBox)control).Checked = false;
                    }
                }
		}

		private string GetResponseTypes()
		{
			var result = String.Empty;

            GroupBox ff = null;

            foreach (var control in this.tpResponseTypes.Controls)
            {
                if (control is GroupBox)
                {
                    if (((GroupBox)control).Name == "groupBox16")
                        ff = (GroupBox)control;
                }
            }
            if (ff != null)
                foreach (var control in ff.Controls)
                {
                    if (control is CheckBox && ((CheckBox)control).Checked)
                    {
                        var text = ((CheckBox)control).Text;

                        result += String.IsNullOrEmpty(result.Trim()) ? text : "," + text;
                    }
                }

			return String.IsNullOrEmpty( result )
			       	? String.Format( "{0}{1}{2}", ( int )HttpStatusCode.OK, ' ', Convert.ToString( HttpStatusCode.OK ) )
			       	: result;
		}

		private void SetValuesForEdit( ScannerSetting setting )
		{
			this.rtbEditFilePath.Text = setting.InputFile;

			if (setting.WebMethod != null)
			{
				IEnumerable<RadioButton> radios = this.tpWebMethod.Controls.OfType< RadioButton >();
                radios.Count();
                RadioButton rad = radios.FirstOrDefault(radio => radio.Tag.ToString().Equals(setting.WebMethod));
                if (rad == null)
                    rad = this.rbGet;
                rad.Checked = true;
			}

			this.tbPort.Text = setting.Port.ToString();
			this.tbIbmFile.Text = setting.IbmFile;
			this.tbWebLogin.Text = setting.Login;
			this.tbWebPassword.Text = setting.Password;
			this.chbIbmEnabled.Checked = setting.IbmCheckEnabled;
			this.tbRawPost.Text = setting.PostRequestString;
			this.cbPostUsernameKeys.DataSource = this.GetKeys();
			this.cbPostPasswordKeys.DataSource = this.GetKeys();
			this.tbCookies.Text = setting.Cookies;

			if( !String.IsNullOrEmpty( setting.ResponseTypes ) )
			{
				var responseTypes = setting.ResponseTypes.Split( ',' ).ToList();

                if ((responseTypes.Count == 0)) // useless
                    responseTypes.Add(setting.ResponseTypes);
                
                GroupBox ff = null;

				foreach( var control in this.tpResponseTypes.Controls )
                {
                    if(control is GroupBox)
                    {
                        if(((GroupBox)control).Name=="groupBox16")
                            ff = (GroupBox)control;
                    }
                }
                if(ff!=null)
                foreach( var control in ff.Controls )
				{
                   // MessageBox.Show(control.ToString());
					if( control is CheckBox )
					{
                        
						( ( CheckBox )control ).Checked = responseTypes.Contains( ( ( CheckBox )control ).Text ) ? true : false;
					}
				}
			}
		}

		private string GetSelectedPath()
		{
			var result = String.Empty;

			if( !String.IsNullOrEmpty( this._cachedFilesFolder ) )
			{
				this.ofdFilePath.InitialDirectory = this._cachedFilesFolder;
			}

			if( this.ofdFilePath.ShowDialog().Equals( DialogResult.OK ) )
			{
				this._cachedFilesFolder = Path.GetDirectoryName( this.ofdFilePath.FileName );
				result = this.ofdFilePath.FileName;
			}

			return result;
		}

		private void ExportScanningResults( bool text )
		{
			if( ScannerManager.ScanDetails == null )
			{
				MessageBox.Show( "There are nothing to export!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error );
				return;
			}
			using( var dialog = new SaveFileDialog() )
			{
				dialog.Filter = text ? "TXT Files (*.txt)|*.txt" : "PDF Files (*.pdf)|*.pdf";

				if( dialog.ShowDialog( this ).Equals( DialogResult.OK ) )
				{
					AgReportBuilder reportBuilder = new AgReportBuilder();
					if( text )
					{
						File.AppendAllText( dialog.FileName, reportBuilder.GetResultForTextExport( ScannerManager.ScanDetails ) );
					}
					else
					{
						reportBuilder.CreateDocument( ScannerManager.ScanDetails, dialog.FileName );
					}

					MessageBox.Show( "Results have been successfully exported!", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information );
				}
			}
		}

		private void ActivateStatusLabel( bool active )
		{
			if( active )
			{
				this.tsDirScanStatusLabel.Text = this.tsStatusLabel.Text = this.tsQuickScanStatus.Text = "Scanning...";
				this.tsDirScanStatusLabel.ForeColor = this.tsStatusLabel.ForeColor = this.tsQuickScanStatus.ForeColor = Color.Red;
			}
			else
			{
				this.tsDirScanStatusLabel.Text = this.tsStatusLabel.Text = this.tsQuickScanStatus.Text = "Ready";
				this.tsDirScanStatusLabel.ForeColor = this.tsStatusLabel.ForeColor = this.tsQuickScanStatus.ForeColor = Color.Black;
			}
		}

		private string GetBaseUrl( string baseUrl )
		{
			var result = baseUrl;

			if( !( result.Contains( "http" ) || result.Contains( "https" ) ) )
			{
				result = String.Format( "{0}{1}", "http://", result );
			}

			if( !result[ result.Length - 1 ].Equals( '/' ) )
			{
				result = String.Format( "{0}{1}", result, '/' );
			}

			return result;
		}

		private void GetSettingsObject( ScannerSetting setting )
		{
			setting.ResponseTypes = this.GetResponseTypes();
			setting.Port = String.IsNullOrEmpty( this.tbPort.Text ) ? 0 : Convert.ToInt32( this.tbPort.Text );
			setting.WebMethod =
				this.tpWebMethod.Controls.OfType< RadioButton >().FirstOrDefault( radio => radio.Checked ).Tag.ToString();
			setting.Login = this.tbWebLogin.Text;
			setting.Password = this.tbWebPassword.Text;
			setting.IbmFile = this.tbIbmFile.Text;
			setting.IbmCheckEnabled = this.chbIbmEnabled.Checked;
			setting.Cookies = this.tbCookies.Text;
			setting.ErrorPageTitle = this.tbErrorPageTitle.Text;
			setting.ErrorPageBodyText = this.tbErrorPageBodyText.Text;
			setting.PostRequestString = this.GetRawPostRequestString();
		}

		private string GetColumnName( int index )
		{
			var colNames = typeof( ScanDetails ).GetProperties();
			var name = colNames[ index ].Name;

			return name;
		}

		private IList< string > GetKeys()
		{
			var result = new List< string >();

			var keyValuePairs = this.tbRawPost.Text.Split( '&' );

			if( keyValuePairs.Length != 0 )
			{
				foreach( var pair in keyValuePairs )
				{
					var v = pair.Split( '=' );

					if( v.Length == 2 && v[ 1 ] != String.Empty )
					{
						result.Add( v[ 0 ] );
					}
				}
			}

			return result;
		}

		private string GetRawPostRequestString()
		{
			StringBuilder sb = new StringBuilder();
			var keyValuePairs = this.tbRawPost.Text.Split( '&' );

			if( keyValuePairs.Length != 0 )
			{
				int pairsCount = 1;
				foreach( var pair in keyValuePairs )
				{
					string postPart;

					if( pair.Contains( this.cbPostPasswordKeys.Text ) )
					{
						postPart = String.Format( "{0}{1}{2}", pair.Split( '=' )[ 0 ], '=', this.tbPostPasswordValue.Text );
					}
					else if( pair.Contains( this.cbPostUsernameKeys.Text ) )
					{
						postPart = String.Format( "{0}{1}{2}", pair.Split( '=' )[ 0 ], '=', this.tbPostUsernameValue.Text );
					}
					else
					{
						postPart = pair;
					}

					if( pairsCount < keyValuePairs.Length )
					{
						postPart += '&';
					}

					sb.Append( postPart );
					pairsCount++;
				}
			}

			return sb.ToString();
		}

		#endregion Methods

		#region Events
		private void bgQuickWorker_RunWorkerCompleted( object sender, RunWorkerCompletedEventArgs e )
		{
			this.DisableControls( this.Controls, true );
			this.ActivateStatusLabel( false );

			if( ScannerManager.ScanDetails != null )
			{
				MessageBox.Show( "Scanning completed!", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information );
			}
		}

		private void bgQuickWorker_DoWork( object sender, DoWorkEventArgs e )
		{
			foreach( var item in this._settingsToCheck )
			{
				this._scannerManager.CheckResourceForFiles( item );
			}
		}

		private void bgDirectoryWorker_RunWorkerCompleted( object sender, RunWorkerCompletedEventArgs e )
		{
			this.gvDirScanResults.DataSource = ScannerManager.ScanDetails;
			this.DisableControls( this.Controls, true );
			this.ActivateStatusLabel( false );

			if( ScannerManager.ScanDetails != null )
			{
				MessageBox.Show( "Scanning completed!", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information );
			}
		}

		private void bgDirectoryWorker_DoWork( object sender, DoWorkEventArgs e )
		{
			foreach( var item in this._settingsToCheck )
			{
				this._scannerManager.CheckResourceForFiles( item );
			}
		}

		private void BgWorkerRunWorkerCompleted( object sender, RunWorkerCompletedEventArgs e )
		{
			this.gvResults.DataSource = ScannerManager.ScanDetails;

			this.DisableControls( this.Controls, true );

			this.ActivateStatusLabel( false );

			if( ScannerManager.ScanDetails != null )
			{
				MessageBox.Show( "Scanning completed!", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information );
			}
		}

		private void BgWorkerDoWork( object sender, DoWorkEventArgs e )
		{
			foreach( var item in this._settingsToCheck )
			{
				if( item.CheckName.Equals( "Frontpage" ) )
				{
					this._scannerManager.CheckFrontpage( item );
				}
				else
				{
					this._scannerManager.CheckResourceForFiles( item );
				}
			}
		}

		private void BtnStartClick( object sender, EventArgs e )
		{
			if( String.IsNullOrEmpty( this.rtbBaseUrl.Text ) )
			{
				MessageBox.Show( "You need to enter url!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning );
				return;
			}

			var url = this.GetBaseUrl( this.rtbBaseUrl.Text.Trim() );

			this._scannerManager = new ScannerManager( url );

			this.ExtractSelectedChecks( true );

			if( this._settingsToCheck.Count == 0 )
			{
				MessageBox.Show( "Please, select atleast one check!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning );
				return;
			}

			this.ActivateStatusLabel( true );

			this.gvResults.DataSource = null;

			this.DisableControls( this.Controls, false );
			this.bgWorker.RunWorkerAsync();
		}

		private void BtnSetFileForEditClick( object sender, EventArgs e )
		{
			this.rtbEditFilePath.Text = this.GetSelectedPath();
		}

		private void BtnSetFileForAddClick( object sender, EventArgs e )
		{
			this.rtbAddFilePath.Text = this.GetSelectedPath();
		}

		private void btnGetIbmFile_Click( object sender, EventArgs e )
		{
			this.tbIbmFile.Text = this.GetSelectedPath();
		}

		private void CbAvailableChecksSelectionChangeCommitted( object sender, EventArgs e )
		{
			var item = this.cbAvailableChecks.SelectedItem;

			this.SetValuesForEdit( ( ScannerSetting )item );
		}

		private void BtnStopClick( object sender, EventArgs e )
		{
			this.bgWorker.CancelAsync();
			MessageBox.Show( "Scanning aborted!", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information );

			this.btnStop.Enabled = false;
			this.ActivateStatusLabel( false );
			this.gvResults.DataSource = null;
			this._scannerManager.Dispose();
			this.DisableControls( this.Controls, true );
		}

		private void button2_Click( object sender, EventArgs e )
		{
			MessageBox.Show( "This tool is simpy helping you discover known files for various CMS, Server Extensions etc. To get started: go to settings and type a name for a new check and select the input file. Each check has to be on a new line without backslashes. The output also shows you the page size. This helps you identify possible false positives (page size -1 means no page size received). In the settings you have to select a response (like 200 OK).By default the scanner uses the 200 OK. multiple choices are possible." );
		}

		private void button3_Click( object sender, EventArgs e )
		{
			MessageBox.Show( "CMS SCAN \nContact: Oliver (a) muenchow.ch\n Credits: Dmitry S and Muenchow O." );
		}

		private void btnDelete_Click( object sender, EventArgs e )
		{
			var item = ( ( ScannerSetting )this.cbChecksForDelete.SelectedItem );

			if( !String.IsNullOrEmpty( item.CheckName ) )
			{
				this._settingsManager.DeleteCheck( item );
				this.ClearSettings();
				this.BindControls();

				MessageBox.Show( "Check was succesfully deleted!", String.Empty, MessageBoxButtons.OK,
				                 MessageBoxIcon.Information );
			}

		}

		private void btnSaveCheck_Click( object sender, EventArgs e )
		{
			if( !this.rtbEditFilePath.Text.Equals( String.Empty ) )
			{
				var setting = new ScannerSetting
					{
						InputFile = this.rtbEditFilePath.Text,
						CheckName = this.cbAvailableChecks.Text,
						DirCheck = this.chbDirScanEdit.Checked
					};

				this.GetSettingsObject( setting );
				this._settingsManager.EditCheck( setting );
			}
			else if( !String.IsNullOrEmpty( this.rtbAddFileName.Text ) &&
			         !String.IsNullOrEmpty( this.rtbAddFilePath.Text ) )
			{
				if( this._settingsManager.IsSettingExists( this.rtbAddFileName.Text ) )
				{
					MessageBox.Show( "Setting with the same name is already exists!", "Warning!", MessageBoxButtons.OK,
					                 MessageBoxIcon.Warning );
					return;
				}

				var setting = new ScannerSetting
					{
						CheckName = this.rtbAddFileName.Text,
						InputFile = this.rtbAddFilePath.Text,
						DirCheck = this.chbDirScanAdd.Checked
					};

				this.GetSettingsObject( setting );
				this._settingsManager.SaveCheck( setting );

			}
			else
			{
				MessageBox.Show( "There is nothing to save.", String.Empty, MessageBoxButtons.OK,
				                 MessageBoxIcon.Information );
				return;
			}

			MessageBox.Show( "Settings was succesfully saved!", String.Empty, MessageBoxButtons.OK,
			                 MessageBoxIcon.Information );
			this.ClearSettings();
			this.BindControls();
		}

		private void gvResults_CellClick( object sender, DataGridViewCellEventArgs e )
		{
			if( e.RowIndex == -1 )
			{
				var name = this.GetColumnName( e.ColumnIndex );

				this._currentSortDirection = this._currentSortDirection.Equals( ListSortDirection.Ascending )
				                             	? ListSortDirection.Descending
				                             	: ListSortDirection.Ascending;

				Utils.SortList< ScanDetails >( ScannerManager.ScanDetails, name, this._currentSortDirection );
				this.gvResults.DataSource = ScannerManager.ScanDetails;
				this.gvResults.Invalidate();
			}
			else if( e.RowIndex != -1 && e.ColumnIndex == 0 )
			{
				var url = this.gvResults.Rows[ e.RowIndex ].Cells[ 0 ].Tag.ToString();
				var body = this.gvResults.Rows[ e.RowIndex ].Cells[ this.gvResults.Rows[ e.RowIndex ].Cells.Count - 3 ].Value.ToString();

				if( !String.IsNullOrEmpty( url ) || !String.IsNullOrEmpty( body ) )
				{
					var dialogResult = MessageBox.Show( "Show source in pop up?\n 'No' answer will open related link in default browser ", String.Empty, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question );

					if( dialogResult.Equals( DialogResult.Yes ) )
					{
						var pageBody = new fmPageBody( body );
						pageBody.Show();
					}
					else if( dialogResult.Equals( DialogResult.No ) )
					{
						System.Diagnostics.Process.Start( url );
					}
					else
					{
						MessageBox.Show( "This URI is downloadable. Unable to open!", String.Empty, MessageBoxButtons.OK,
						                 MessageBoxIcon.Information );
					}
				}
			}
		}

		private void gvDirScanResults_CellClick( object sender, DataGridViewCellEventArgs e )
		{
			if( e.RowIndex == -1 )
			{
				var colNames = typeof( ScanDetails ).GetProperties();
				var name = colNames[ e.ColumnIndex ].Name;

				this._currentSortDirection = this._currentSortDirection.Equals( ListSortDirection.Ascending )
				                             	? ListSortDirection.Descending
				                             	: ListSortDirection.Ascending;

				Utils.SortList< ScanDetails >( ScannerManager.ScanDetails, name, this._currentSortDirection );
				this.gvDirScanResults.DataSource = ScannerManager.ScanDetails;
				this.gvDirScanResults.Invalidate();
			}
		}

		private void gvResults_DataBindingComplete( object sender, DataGridViewBindingCompleteEventArgs e )
		{
			DataGridViewCellStyle cellStyle = this.gvResults.DefaultCellStyle.Clone();
			cellStyle.ForeColor = Color.Blue;

			this.gvResults.Columns[ 0 ].DefaultCellStyle = cellStyle;
			this.gvResults.Columns[ this.gvResults.Columns.Count - 1 ].Visible = false;
		}

		private void gvResults_CellMouseMove( object sender, DataGridViewCellMouseEventArgs e )
		{
			if( e.RowIndex >= 0 && e.ColumnIndex == 0 )
			{
				this.Cursor = Cursors.Hand;
				this.gvResults.Rows[ e.RowIndex ].Cells[ e.ColumnIndex ].ToolTipText = "View page body in a new window";
			}
			else
			{
				this.Cursor = Cursors.Default;
			}
		}

		private void tbRawPost_TextChanged( object sender, EventArgs e )
		{
			this.cbPostUsernameKeys.DataSource = this.GetKeys();
			this.cbPostPasswordKeys.DataSource = this.GetKeys();
		}

		private void btnStartDirScan_Click( object sender, EventArgs e )
		{
			if( String.IsNullOrEmpty( this.rtbDirScanTarget.Text ) )
			{
				MessageBox.Show( "You need to enter url!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning );
				return;
			}

			var url = this.GetBaseUrl( this.rtbDirScanTarget.Text.Trim() );

			this._scannerManager = new ScannerManager( url );

			this.ExtractSelectedChecks( false );

			if( this._settingsToCheck.Count == 0 )
			{
				MessageBox.Show( "Please, select atleast one check!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning );
				return;
			}

			this.ActivateStatusLabel( true );

			this.gvDirScanResults.DataSource = null;

			this.DisableControls( this.Controls, false );
			this.bgDirectoryWorker.RunWorkerAsync();
		}

		private void btnStopDirScan_Click( object sender, EventArgs e )
		{
			this.bgWorker.CancelAsync();
			MessageBox.Show( "Scanning aborted!", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information );

			this.btnStopDirScan.Enabled = false;
			this.ActivateStatusLabel( false );
			this.gvDirScanResults.DataSource = null;
			this._scannerManager.Dispose();
			this.DisableControls( this.Controls, true );
		}

		private void gvResults_CellFormatting( object sender, DataGridViewCellFormattingEventArgs e )
		{
			if( e.ColumnIndex == 0 )
			{
				this.gvResults.Rows[ e.RowIndex ].Cells[ 0 ].Tag = e.Value;
				//e.Value = "Open in a new window";
			}
		}

		private void gvDirScanResults_DataBindingComplete( object sender, DataGridViewBindingCompleteEventArgs e )
		{
			for( int i = this.gvDirScanResults.Columns.Count - 1; i > 3; i-- )
			{
				this.gvDirScanResults.Columns[ i ].Visible = false;
			}
		}

		private void btnExportDirs_Click( object sender, EventArgs e )
		{
			this.ExportScanningResults( this.rbExportDirsToText.Checked );
		}

		private void BtnExportClick( object sender, EventArgs e )
		{
			this.ExportScanningResults( this.rbFilesExportToText.Checked );
		}

		private void btnQuickStart_Click( object sender, EventArgs e )
		{
			if( String.IsNullOrEmpty( this.rtb_QuickScanUrl.Text ) )
			{
				MessageBox.Show( "You need to enter url!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning );
				return;
			}

			var url = this.GetBaseUrl( this.rtb_QuickScanUrl.Text.Trim() );

			this._scannerManager = new ScannerManager( url );
			this._settingsToCheck = new List< ScannerSetting >
				{
					this._settingsManager.GetSettingByName( "backend_dirs", true ),
					this._settingsManager.GetSettingByName( "general_Nikto", true )
				};

			this.ActivateStatusLabel( true );

			this.DisableControls( this.Controls, false );
			this.bgQuickWorker.RunWorkerAsync();
		}

		private void btnQuickStop_Click( object sender, EventArgs e )
		{
			this.bgQuickWorker.CancelAsync();
			MessageBox.Show( "Scanning aborted!", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information );

			this.btnQuickStop.Enabled = false;
			this.ActivateStatusLabel( false );
			this._scannerManager.Dispose();
			this.DisableControls( this.Controls, true );
		}

		private void btnQuickExport_Click( object sender, EventArgs e )
		{
			this.ExportScanningResults( this.rbQuickExportToText.Checked );
		}

		#endregion Events

        private void label57_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Registered = false;
            Properties.Settings.Default.Save();
            MessageBox.Show("Application unregistered. You will be prompted for key next time you run.");
            
        }
	}
}
