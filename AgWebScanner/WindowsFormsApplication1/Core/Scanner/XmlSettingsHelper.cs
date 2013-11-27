using System.Xml;
using System.Xml.Linq;
using System.Collections.Generic;
using System;

namespace AgWebScanner.Core.Scanner
{
	internal class XmlSettingsHelper
	{
		private string _settingsFilePath = String.Empty;
		private readonly XDocument _document;

		public XmlSettingsHelper( string settingsFilePath )
		{
			this._settingsFilePath = settingsFilePath;
			this._document = XDocument.Load( settingsFilePath );
		}

		public void AddSetting( ScannerSetting setting )
		{
			var element = new XElement( SettingNode.RootName,
			                            new XElement( SettingNode.Name, setting.CheckName ),
			                            new XElement( SettingNode.File, setting.InputFile ),
			                            new XElement( SettingNode.ResponseTypes, setting.ResponseTypes ),
			                            new XElement( SettingNode.WebMethod, setting.WebMethod ),
			                            new XElement( SettingNode.Port, setting.Port.ToString() ),
			                            new XElement( SettingNode.Login, setting.Login ),
			                            new XElement( SettingNode.Password, setting.Password ),
			                            new XElement( SettingNode.IbmFile, setting.IbmFile ),
			                            new XElement( SettingNode.IbmCheckEnabled, Convert.ToString( setting.IbmCheckEnabled ) ),
			                            new XElement( SettingNode.Cookies, setting.Cookies ),
			                            new XElement( SettingNode.ErrorPageTitle, setting.ErrorPageTitle ),
			                            new XElement( SettingNode.ErrorPageBodyText, setting.ErrorPageBodyText ),
			                            new XElement( SettingNode.PostRequestString, setting.PostRequestString ),
			                            new XElement( SettingNode.DirCheck, setting.DirCheck ) );

			this._document.Root.Add( element );
			this._document.Save( this._settingsFilePath );
		}

		public void EditSetting( ScannerSetting setting )
		{
			var node = this._document.Root.FirstNode;

			while( node != null )
			{
				var element = ( XElement )node;

				if( ( node.NodeType.Equals( XmlNodeType.Element ) ) &&
				    element.Element( SettingNode.Name ).Value.Equals( setting.CheckName ) )
				{
					element.Element( SettingNode.File ).Value = setting.InputFile;
					element.Element( SettingNode.ResponseTypes ).Value = setting.ResponseTypes;
					element.Element( SettingNode.Port ).Value = setting.Port.ToString();
					element.Element( SettingNode.WebMethod ).Value = setting.WebMethod;
					element.Element( SettingNode.Login ).Value = setting.Login;
					element.Element( SettingNode.Password ).Value = setting.Password;
					element.Element( SettingNode.IbmFile ).Value = setting.IbmFile;
					element.Element( SettingNode.IbmCheckEnabled ).Value = Convert.ToString( setting.IbmCheckEnabled );
					element.Element( SettingNode.Cookies ).Value = setting.Cookies;
					element.Element( SettingNode.ErrorPageTitle ).Value = setting.ErrorPageTitle;
					element.Element( SettingNode.ErrorPageBodyText ).Value = setting.ErrorPageBodyText;
					element.Element( SettingNode.PostRequestString ).Value = setting.PostRequestString;
					element.Element( SettingNode.DirCheck ).Value = Convert.ToString( setting.DirCheck );

					break;
				}

				node = node.NextNode;
			}

			this._document.Save( this._settingsFilePath );
		}

		public void DeleteSetting( ScannerSetting setting )
		{
			var node = this._document.Root.FirstNode;

			while( node != null )
			{
				var element = ( XElement )node;

				if( ( node.NodeType.Equals( XmlNodeType.Element ) ) &&
				    element.Element( SettingNode.Name ).Value.Equals( setting.CheckName ) )
				{
					element.Remove();
					break;
				}

				node = node.NextNode;
			}

			this._document.Save( this._settingsFilePath );
		}

		public IList< ScannerSetting > GetSettings()
		{
			var result = new List< ScannerSetting >();
			var node = this._document.Root.FirstNode;

			while( node != null )
			{
				if( ( node.NodeType.Equals( XmlNodeType.Element ) ) )
				{
					result.Add( ExtractSettingsFromNode( node ) );
				}

				node = node.NextNode;
			}

			return result;
		}

		public ScannerSetting GetSettingByName( string name )
		{
			ScannerSetting result = null;
			var node = this._document.Root.FirstNode;

			while( node != null )
			{
				var element = ( XElement )node;
				if( ( node.NodeType.Equals( XmlNodeType.Element ) ) &&
				    element.Element( SettingNode.Name ).Value.Equals( name ) )
				{
					result = ExtractSettingsFromNode( node );
					break;
				}

				node = node.NextNode;
			}

			return result;
		}

		public bool IsSettingExists( string name )
		{
			var result = false;
			var node = this._document.Root.FirstNode;

			while( node != null )
			{
				if( ( node.NodeType.Equals( XmlNodeType.Element ) ) &&
				    ( ( XElement )node ).Element( SettingNode.Name ).Value.Equals( name ) )
				{
					result = true;
					break;
				}

				node = node.NextNode;
			}

			return result;
		}

		private static ScannerSetting ExtractSettingsFromNode( XNode node )
		{
			var element = ( XElement )node;

			return new ScannerSetting
				{
					CheckName = element.Element( SettingNode.Name ).Value,
					InputFile = element.Element( SettingNode.File ).Value,
					ResponseTypes = element.Element( SettingNode.ResponseTypes ).Value,
					Port = Convert.ToInt32( element.Element( SettingNode.Port ).Value ),
					WebMethod = element.Element( SettingNode.WebMethod ).Value,
					Login = element.Element( SettingNode.Login ).Value,
					Password = element.Element( SettingNode.Password ).Value,
					IbmFile = element.Element( SettingNode.IbmFile ).Value,
					IbmCheckEnabled = Convert.ToBoolean( element.Element( SettingNode.IbmCheckEnabled ).Value.ToLower() ),
					Cookies = element.Element( SettingNode.Cookies ).Value,
					PostRequestString = element.Element( SettingNode.PostRequestString ).Value,
					DirCheck = Convert.ToBoolean( element.Element( SettingNode.DirCheck ).Value.ToLower() ),
				};
		}
	}
}

