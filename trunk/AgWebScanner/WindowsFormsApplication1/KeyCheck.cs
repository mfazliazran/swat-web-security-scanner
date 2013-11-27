using System;
using System.IO;
using System.Windows.Forms;
using AgWebScanner.Core.Scanner;

namespace AgWebScanner
{
	public partial class KeyCheck : Form
	{
		public KeyCheck()
		{
			InitializeComponent();
		}

		private void btnOk_Click( object sender, EventArgs e )
		{
			if( this.tbKey.Text.Equals( Properties.Settings.Default.Key ) )
			{
				Properties.Settings.Default.Registered = true;
				Properties.Settings.Default.Save();
				this.Hide();

				//Once user successfully register his version,
				//default checks will be created
				this.AddDefaultChecks();

				FmScanner scanner = new FmScanner();
				scanner.Show();
			}
			else
			{
				this.tbKey.Text = String.Empty;
				MessageBox.Show( "Wrong key!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error );
			}
		}

		private void AddDefaultChecks()
		{
			var appPath = String.Format( "{0}{1}", Application.StartupPath, Properties.Settings.Default.DefaultChecksFolder );
			string[] files = Directory.GetFiles( appPath );
			var settingsManager = new SettingsManager();

            //System.Collections.Generic.IList 
            //IList<ScannerSetting> setf = settingsManager.GetSettings();
            //foreach( var set in setf)
            //    settingsManager.DeleteCheck(

			foreach( var file in files )
			{
                string fname = Path.GetFileName(file.Substring(Application.StartupPath.Length)).Split( '.' )[ 0 ];

                if(settingsManager.IsSettingExists(fname))
                    settingsManager.DeleteCheck( settingsManager.GetSettingByName(fname,false) );

				var defaultCheck = new ScannerSetting
					{
                        InputFile = file.Substring(Application.StartupPath.Length),
						CheckName = Path.GetFileName( file ).Split( '.' )[ 0 ],
						ResponseTypes = "200 OK"
					};
				settingsManager.SaveCheck( defaultCheck );
			}
		}
	}
}
