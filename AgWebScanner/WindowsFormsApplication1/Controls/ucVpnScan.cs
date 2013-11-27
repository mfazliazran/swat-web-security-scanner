using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using AgWebScanner.Core.VpnScanner;

namespace AgWebScanner.Controls
{
	public partial class ucVpnScan : UserControl
	{
		#region Fields

		private JuniperManager _juniperManager;
		private ScannerSetting _scannerSetting;
		private AttackSettings _attackSettings;
		private readonly Bitmap OkImg = Properties.Resources.ok;
		private readonly Bitmap ErrorImg = Properties.Resources.warning;

		#endregion Fields

		#region Constructors

		public ucVpnScan()
		{
			this.InitializeComponent();
			this.InitializeMembers();
		}

		#endregion Constructors

		#region Methods

		private void InitializeMembers()
		{
			this.btnStop.Enabled = false;

			this.bgWorker.DoWork += this.BgWorkerDoWork;
			this.bgWorker.RunWorkerCompleted += this.BgWorkerRunWorkerCompleted;
			this.bgWorker.WorkerReportsProgress = true;
			this.bgWorker.WorkerSupportsCancellation = true;

			this.bgwDictionaryAttack.DoWork += this.bgwDictionaryAttack_DoWork;
			this.bgwDictionaryAttack.RunWorkerCompleted += this.bgwDictionaryAttack_RunWorkerCompleted;
			this.bgwDictionaryAttack.WorkerReportsProgress = true;
			this.bgwDictionaryAttack.WorkerSupportsCancellation = true;
		}

		private void ActivateStatusLabel( bool active )
		{
			if( active )
			{
				this.statusLabel.Text = "Scanning...";
				this.statusLabel.ForeColor = Color.Red;
			}
			else
			{
				this.statusLabel.Text = "Ready";
				this.statusLabel.ForeColor = Color.Black;
			}
		}

		private string GetBaseUrl()
		{
			var result = this.tbUrl.Text.Trim();

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

		private void ExportScanningResults()
		{
			if( JuniperManager.ResponseDetails == null )
			{
				MessageBox.Show( "There are nothing to export!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error );
				return;
			}
			using( var dialog = new SaveFileDialog() )
			{
				dialog.Filter = "Text Files (*.txt)|*.txt";

				if( dialog.ShowDialog( this ).Equals( DialogResult.OK ) )
				{
					File.AppendAllText( dialog.FileName, JuniperManager.GetResultForExport() );
					MessageBox.Show( "Results have been successfully exported!", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information );
				}
			}
		}

		private void DisableControls( Control.ControlCollection controls, bool state )
		{
			foreach( Control control in controls )
			{
				if( control is GroupBox )
				{
					this.DisableControls( control.Controls, state );
				}

				else if( !control.Name.Equals( "btnStop" ) &&
				         !( control is StatusStrip ) )
				{
					control.Enabled = state;
				}

			}
			this.btnStop.Enabled = !state;
		}

		private bool AtLeastOneCheckSelected()
		{
			var result = false;

			foreach( var control in this.gbChecks.Controls )
			{
				if( control is CheckBox && ( ( CheckBox )control ).Checked )
				{
					result = true;
					break;
				}
			}

			return result;
		}

		private void SetResponseSummary()
		{
			if( this.chbAdminAccess.Checked )
				this.pbAdminAccess.Image = JuniperManager.ResponseSummary.AdminAccessOk ? this.OkImg : this.ErrorImg;
			if( this.chbAuthByPass.Checked )
				this.pbAuthByPass.Image = JuniperManager.ResponseSummary.AuthByPassOk ? this.ErrorImg : this.OkImg;
			if( this.chbMeetingTest.Checked )
				this.pbMeetingTest.Image = JuniperManager.ResponseSummary.MeetingTestOk ? this.ErrorImg : this.OkImg;
			if( this.chbSetupFiles.Checked )
				this.pbSetupFiles.Image = JuniperManager.ResponseSummary.SetupFilesOk ? this.ErrorImg : this.OkImg;
			if( this.chbMultipleSignInPages.Checked )
				this.pbSignInPages.Image = JuniperManager.ResponseSummary.SignInPagesOk ? this.OkImg : this.ErrorImg;
			if( this.chbWebRoot.Checked )
				this.pbWebRoot.Image = JuniperManager.ResponseSummary.WebRootOk ? this.ErrorImg : this.OkImg;
			if( this.chbCheckXss.Checked )
				this.pbXssTest.Image = JuniperManager.ResponseSummary.XssTestOk ? this.ErrorImg : this.OkImg;
		}

		private void ClearResponseSummary()
		{
			foreach( var control in this.gbResultsSummary.Controls )
			{
				if( control is PictureBox )
				{
					( ( PictureBox )control ).Image = null;
				}
			}
		}

		#endregion Methods

		#region Events

		private void BgWorkerRunWorkerCompleted( object sender, RunWorkerCompletedEventArgs e )
		{
			if( this._juniperManager != null )
			{
				this.gvResults.DataSource = JuniperManager.ResponseDetails;

				this.DisableControls( this.Controls, true );
				this.ActivateStatusLabel( false );
				this.SetResponseSummary();


				if( JuniperManager.ResponseDetails != null )
				{
					MessageBox.Show( "Scanning completed!", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information );

					if( this.chbMultipleSignInPages.Checked )
					{
						this.cbUrlsToAttack.DataSource = JuniperManager.ResponseSummary.SignInGeneratedUrls;
						this._scannerSetting = new ScannerSetting();
					}
				}
			}
		}

		private void BgWorkerDoWork( object sender, DoWorkEventArgs e )
		{
			this._juniperManager.CheckResource( this._scannerSetting );
		}

		private void btnStart_Click( object sender, EventArgs e )
		{

			if( String.IsNullOrEmpty( this.tbUrl.Text ) )
			{
				MessageBox.Show( "You need to enter url!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning );
				return;
			}

			if( !this.AtLeastOneCheckSelected() )
			{
				MessageBox.Show( "You must select at least one check!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning );
				return;
			}

			this.gvResults.DataSource = null;
			this.ClearResponseSummary();
			this._juniperManager = new JuniperManager( this.GetBaseUrl() );
			this._scannerSetting = new ScannerSetting
				{
					MinId = ( int )this.nudMin.Value,
					MaxId = ( int )this.nudMax.Value,
					CheckMultipleSignInPages = this.chbMultipleSignInPages.Checked,
					CheckWebRoot = this.chbWebRoot.Checked,
					CheckSetupFiles = this.chbSetupFiles.Checked,
					CheckAuthByPass = this.chbAuthByPass.Checked,
					CheckXssVulnerability = this.chbCheckXss.Checked,
					CheckAdminAccess = this.chbAdminAccess.Checked,
					CheckMeetingTest = this.chbMeetingTest.Checked
				};

			this.ActivateStatusLabel( true );
			this.DisableControls( this.Controls, false );
			this.bgWorker.RunWorkerAsync();
		}

		private void btnStop_Click( object sender, EventArgs e )
		{
			this.bgWorker.CancelAsync();
			MessageBox.Show( "Scanning aborted!", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information );
			this.btnStop.Enabled = false;
			this.ActivateStatusLabel( false );
			this.ClearResponseSummary();
			this.gvResults.DataSource = null;
			this._juniperManager.Dispose();
			this._juniperManager = null;
			this.DisableControls( this.Controls, true );
		}


		private void btnHelp_Click( object sender, EventArgs e )
		{
			MessageBox.Show( "The VPN Scanner is targeted against Junipers VPN device. It will test for common\n vulnerabilities. It also gives you the possibility to discover multiple\n login pages that can by defined on the remote device." );
		}

		private void btnAbout_Click( object sender, EventArgs e )
		{
			MessageBox.Show( "CMS SCAN \nContact: Oliver (a) muenchow.ch\n Credits: Dmitry S." );
		}

		private void btnExport_Click( object sender, EventArgs e )
		{
			this.ExportScanningResults();
		}

		private void chbCheckAll_CheckedChanged( object sender, EventArgs e )
		{
			var state = this.chbCheckAll.Checked;

			foreach( var item in this.gbChecks.Controls )
			{
				( ( CheckBox )item ).Checked = state;
			}
		}

		#endregion Events

		#region Dictionary Attack

		#region Methods

		private void GetFilePath( TextBox textBox )
		{
			using( var dialog = new OpenFileDialog() )
			{
				dialog.Filter = "Text Files (*.txt)|*.txt";

				if( dialog.ShowDialog( this ).Equals( DialogResult.OK ) )
				{
					textBox.Text = dialog.FileName;
				}
			}
		}

		private void CreateAttackParams()
		{
			if( !File.Exists( this.tbUsernamesFilePath.Text ) ||
			    !File.Exists( this.tbPasswordFilePath.Text ) )
			{
				MessageBox.Show( "Some of the specified files is not exists!", "Warning!", MessageBoxButtons.OK,
				                 MessageBoxIcon.Warning );
				return;
			}

			var names = File.ReadAllText( this.tbUsernamesFilePath.Text ).Split( '\n' );
			var passwords = File.ReadAllText( this.tbPasswordFilePath.Text ).Split( '\n' );

			foreach( var name in names )
			{
				foreach( var pass in passwords )
				{
					var param = String.Format( "{0}{1}{2}{3}{4}{5}{6}", this.tbUserName.Text, "=", name.Replace( '\r', ' ' ).Trim(), "&",
					                           this.tbPassword.Text, "=", pass.Replace( '\r', ' ' ).Trim() );
					this._attackSettings.AttackParams.Add( param );
				}
			}
		}

		#endregion Methods

		#region Events

		private void btnLoadUsernames_Click( object sender, EventArgs e )
		{
			this.GetFilePath( this.tbUsernamesFilePath );
		}

		private void tbUsernamesFilePath_MouseClick( object sender, MouseEventArgs e )
		{
			this.GetFilePath( this.tbUsernamesFilePath );
		}

		private void tbPasswordFilePath_MouseClick( object sender, MouseEventArgs e )
		{
			this.GetFilePath( this.tbPasswordFilePath );
		}

		private void btnLoadPasswords_Click( object sender, EventArgs e )
		{
			this.GetFilePath( this.tbPasswordFilePath );
		}

		private void btnStartAttack_Click( object sender, EventArgs e )
		{
			if( String.IsNullOrEmpty( this.tbPassword.Text ) ||
			    String.IsNullOrEmpty( this.tbUserName.Text ) ||
			    String.IsNullOrEmpty( this.tbUsernamesFilePath.Text ) ||
			    String.IsNullOrEmpty( this.tbPasswordFilePath.Text ) ||
			    String.IsNullOrEmpty( this.cbUrlsToAttack.Text.Trim() ) )
			{
				MessageBox.Show( "All of the attack settings should be specified!", "Warning!", MessageBoxButtons.OK,
				                 MessageBoxIcon.Warning );
				return;
			}

			this._attackSettings = new AttackSettings();
			this.CreateAttackParams();
			this._attackSettings.AttackUrl = this.cbUrlsToAttack.Text.Trim();

			this.bgwDictionaryAttack.RunWorkerAsync();
		}

		private void bgwDictionaryAttack_DoWork( object sender, DoWorkEventArgs e )
		{
			this._juniperManager.CheckResource( this._attackSettings );
		}

		private void bgwDictionaryAttack_RunWorkerCompleted( object sender, RunWorkerCompletedEventArgs e )
		{
			if( this._juniperManager != null )
			{
				this.gvAttackResult.DataSource = JuniperManager.ResponseDetails;
			}
		}

		#endregion Events

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

		#endregion Dictionary Attack

        private void btnExportAttackResults_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }
	}
}
