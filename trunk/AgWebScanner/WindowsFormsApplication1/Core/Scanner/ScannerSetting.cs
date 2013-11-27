using System.Collections.Generic;
using System.Linq;

namespace AgWebScanner.Core.Scanner
{
	internal class ScannerSetting
	{
		public string CheckName { get; set; }
		public string InputFile { get; set; }
		public string Folder { get; set; }
		public string WebMethod { get; set; }
		public int Port { get; set; }
		public string Login { get; set; }
		public string Password { get; set; }
		public string IbmFile { get; set; }
		public bool IbmCheckEnabled { get; set; }
		public string Cookies { get; set; }
		public string ErrorPageTitle { get; set; }
		public string ErrorPageBodyText { get; set; }
		public string PostRequestString { get; set; }
		public bool DirCheck { get; set; }

		private string _responseTypes;

		public string ResponseTypes
		{
			get
			{
				if( string.IsNullOrEmpty( this._responseTypes ) )
				{
					return this._responseTypes = DefaultResponses;
				}

				return this._responseTypes;
			}
			set { this._responseTypes = value; }
		}

		private const string DefaultResponses = "200 OK, 403 Forbidden";

		public static IList< string > GetStatusCodesList( string statuses )
		{
			var parsed = statuses.Split( ',' );

			return parsed.Select( item => item.Split( ' ' )[ 1 ] ).ToList();
		}
	}
}
