using System.Collections.Generic;

namespace AgWebScanner.Core.Scanner
{
	internal class SettingsManager
	{
		private readonly string _settingsFilePath = Properties.Settings.Default.SettingsFile;
		private readonly XmlSettingsHelper _settingsHelper;

		public SettingsManager()
		{
			this._settingsHelper = new XmlSettingsHelper( this._settingsFilePath );
		}

		public void SaveCheck( ScannerSetting setting )
		{
			this._settingsHelper.AddSetting( setting );
		}

		public void EditCheck( ScannerSetting setting )
		{
			this._settingsHelper.EditSetting( setting );
		}

		public void DeleteCheck( ScannerSetting setting )
		{
			this._settingsHelper.DeleteSetting( setting );
		}

		public IList< ScannerSetting > GetSettings()
		{
			return this._settingsHelper.GetSettings();
		}

		public ScannerSetting GetSettingByName( string name, bool quickScan )
		{
			ScannerSetting result;
			if( quickScan )
			{
				var helper = new XmlSettingsHelper( Properties.Settings.Default.QuickScanSettings );
				result = helper.GetSettingByName( name );
			}
			else
			{
				result = this._settingsHelper.GetSettingByName( name );
			}
			return result;
		}

		public bool IsSettingExists( string name )
		{
			return this._settingsHelper.IsSettingExists( name );
		}
	}
}
