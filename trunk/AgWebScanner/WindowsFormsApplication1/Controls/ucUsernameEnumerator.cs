using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using AgWebScanner.Core.UsernameEnumerator;

namespace AgWebScanner.Controls
{
	public partial class ucUsernameEnumerator : UserControl
	{
		#region Fields

		private UsernameEnumeratorManager _usernameManager;
		private UsernameEnumeratorSetting _usernameSetting;

		#endregion Fields

		#region Constructros

		public ucUsernameEnumerator()
		{
			this.InitializeComponent();
			this.InitializeMembers();
		}

		#endregion Constructros

		#region Methods

		private void InitializeMembers()
		{
			this.btnStop.Enabled = false;
			this.bgWorker.DoWork += this.BgWorkerDoWork;
			this.bgWorker.RunWorkerCompleted += this.BgWorkerRunWorkerCompleted;
			this.bgWorker.WorkerReportsProgress = true;
			this.bgWorker.WorkerSupportsCancellation = true;
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

			return String.Format( "{0}{1}", result, "?" );
		}

		private void ExportScanningResults()
		{
			if( UsernameEnumeratorManager.ResponseDetails == null )
			{
				MessageBox.Show( "There are nothing to export!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error );
				return;
			}
			using( var dialog = new SaveFileDialog() )
			{
				dialog.Filter = "Text Files (*.txt)|*.txt";

				if( dialog.ShowDialog( this ).Equals( DialogResult.OK ) )
				{
					File.AppendAllText( dialog.FileName, UsernameEnumeratorManager.GetResultForExport() );
					MessageBox.Show( "Results have been successfully exported!", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information );
				}
			}
		}

		private void DisableControls( ControlCollection controls, bool state )
		{
			foreach( Control control in controls )
			{
				if( control is GroupBox )
				{
					this.DisableControls( control.Controls, state );
				}

				else if( !( ( Control )control ).Name.Equals( "btnStop" ) &&
				         !( control is StatusStrip ) )
				{
					( ( Control )control ).Enabled = state;
				}
			}

			this.btnStop.Enabled = !state;
		}

		private bool IsSettingsValid()
		{
			if( String.IsNullOrEmpty( this.tbUrl.Text ) )
			{
				MessageBox.Show( "You need to enter url!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning );
				return false;
			}

			if( String.IsNullOrEmpty( this.tbTextToSearch.Text ) )
			{
				MessageBox.Show( "\"Text To Search\" field should be specified!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning );
				return false;
			}

			if( String.IsNullOrEmpty( this.tbParams.Text ) )
			{
				MessageBox.Show( "Parameters should be presented!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning );
				return false;
			}

			if( !this.tbParams.Text.Contains( '=' ) )
			{
				MessageBox.Show( "Parameters string is not a well-formed. Should contains at least one key-value pair!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning );
				return false;
			}

			return true;
		}

		private void GetUserNamesFilePath()
		{
			using( var dialog = new OpenFileDialog() )
			{
				dialog.Filter = "Text Files (*.txt)|*.txt";

				if( dialog.ShowDialog( this ).Equals( DialogResult.OK ) )
				{
					this.tbVariablesFilePath.Text = dialog.FileName;
				}
			}
		}

		private void GetUserNmaeParameters()
		{
			this._usernameSetting.ParamStrings = new List< string >();
			this._usernameSetting.UserNames = new List< string >();

			var fileContent = File.ReadAllText( this.tbVariablesFilePath.Text ).Split( '\n' );
			var userNameKey = this.cbKeys.Text.Trim();
			var KeyValuePairs = this.tbParams.Text.Split( '&' ).ToList();

			//I think that we should check the original (not modified) params too. Could be modified if necessary
			this._usernameSetting.ParamStrings.Add( this.tbParams.Text.Trim() );
			this._usernameSetting.UserNames.Add( this.GetBaseUserNameValue( KeyValuePairs ) );

			for( var i = 0; i < fileContent.Length; i++ )
			{
				var userNameValue = fileContent[ i ].Replace( '\r', ' ' ).Trim();

				//replace username_value with value from the file and store it to the list var
				var userNamekeyValue = String.Format( "{0}{1}{2}", userNameKey, '=', userNameValue );
				var modifiedParamString = String.Empty;

				for( var j = 0; j < KeyValuePairs.Count; j++ )
				{
					if( KeyValuePairs[ j ].Contains( userNameKey ) )
					{
						modifiedParamString += userNamekeyValue;
					}
					else
					{
						modifiedParamString += KeyValuePairs[ j ];
					}

					if( j != KeyValuePairs.Count )
					{
						modifiedParamString += '&';
					}
				}

				this._usernameSetting.ParamStrings.Add( modifiedParamString );
				this._usernameSetting.UserNames.Add( userNameValue );
			}
		}

		private string GetBaseUserNameValue( IEnumerable< string > keyValuePairs )
		{
			var result = String.Empty;

			foreach( var pair in keyValuePairs )
			{
				if( pair.Contains( this.cbKeys.Text ) )
				{
					result = pair.Split( '=' )[ 1 ];
					break;
				}
			}

			return result;
		}

		private IList< string > GetKeys()
		{
			var result = new List< string >();

			var KeyValuePairs = this.tbParams.Text.Split( '&' );

			if( KeyValuePairs.Length != 0 )
			{
				foreach( var pair in KeyValuePairs )
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

		#endregion Methods

		#region Events

		private void BgWorkerRunWorkerCompleted( object sender, RunWorkerCompletedEventArgs e )
		{
			if( this._usernameManager != null )
			{
				this.gvResults.DataSource = UsernameEnumeratorManager.ResponseDetails;

				this.DisableControls( this.Controls, true );
				this.ActivateStatusLabel( false );

				if( UsernameEnumeratorManager.ResponseDetails != null )
				{
					MessageBox.Show( "Scanning completed!", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information );
				}
			}
		}

		private void BgWorkerDoWork( object sender, DoWorkEventArgs e )
		{
			this._usernameManager.CheckResource( this._usernameSetting );
		}

		private void btnStart_Click( object sender, EventArgs e )
		{
			if( this.IsSettingsValid() )
			{

				this.gvResults.DataSource = null;
				this._usernameManager = new UsernameEnumeratorManager( this.GetBaseUrl() );
				this._usernameSetting = new UsernameEnumeratorSetting
					{
						TextToSearch = this.tbTextToSearch.Text,
						Method = this.rbGet.Checked ? this.rbGet.Text : this.rbPost.Text,
						UrlParameters = this.tbParams.Text
					};
				this.GetUserNmaeParameters();
				this.ActivateStatusLabel( true );
				this.DisableControls( this.Controls, false );
				this.bgWorker.RunWorkerAsync();
			}
		}

		private void btnStop_Click( object sender, EventArgs e )
		{
			this.bgWorker.CancelAsync();
			MessageBox.Show( "Scanning aborted!", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information );

			this.btnStop.Enabled = false;
			this.ActivateStatusLabel( false );
			this.gvResults.DataSource = null;
			this._usernameManager.Dispose();
			this._usernameManager = null;

			this.DisableControls( this.Controls, true );
		}

		private void btnExport_Click( object sender, EventArgs e )
		{
			this.ExportScanningResults();
		}

		private void btnHelp_Click( object sender, EventArgs e )
		{
			MessageBox.Show( "This tool helps you enumerate usernames based on an error message\n You have to paste the content from the GET or POST request\n in here and then define which variable is can be replaced by an input\n text file with usernames. SWAT comes with an existing username file in\n the installation directory called users.txt." );
		}

		private void btnAbout_Click( object sender, EventArgs e )
		{
			MessageBox.Show( "USERNAME ENUMERATOR \nContact: Oliver (a) muenchow.ch\n Credits: Dmitry S." );
		}

		private void btnLoadVariablesFile_Click( object sender, EventArgs e )
		{
			this.GetUserNamesFilePath();
		}

		private void tbVariablesFilePath_Click( object sender, EventArgs e )
		{
			this.GetUserNamesFilePath();
		}

		private void tbParams_TextChanged( object sender, EventArgs e )
		{
			this.cbKeys.DataSource = this.GetKeys();
		}

		#endregion Events
	}
}
