using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using HtmlAgilityPack;

namespace AgWebScanner.Core.Scanner
{
	internal class ScannerManager : IDisposable
	{
		#region Fields

		public static List< ScanDetails > ScanDetails { get; set; }
		private static string _baseUrl;
		private static Mutex _mutex;
		private static ScannerSetting _scannerSetting;
		private List< Thread > _threads;
		private static CookieContainer _cookieContainer;
		private static string _errorPageTitle;
		private static string _errorPageBodyText;
		private static volatile bool _terminate;
		#endregion Fields

		#region Constructors

		public ScannerManager( string baseUrl )
		{
			ScanDetails = new List< ScanDetails >();
			_baseUrl = baseUrl;
			_terminate = false;
		}

		#endregion Constructors

		#region Methods

		public void Dispose()
		{
			if( this._threads != null )
			{
				_terminate = true;
				foreach( var t in this._threads )
				{
					t.Interrupt();
				}

				ScanDetails = null;
			}
		}


		public void CheckResourceForFiles( ScannerSetting setting )
		{
			if( String.IsNullOrEmpty( _baseUrl ) )
			{
				return;
			}

			ScanDetails = ScanDetails ?? new List< ScanDetails >();

			_mutex = new Mutex( false );

			_scannerSetting = setting;

			var content = GetRequestContent();

			_cookieContainer = new CookieContainer();

			this.PerformRequest( content );
		}

		public void CheckFrontpage( ScannerSetting setting )
		{
			_scannerSetting = setting;

			ScanDetails = ScanDetails ?? new List< ScanDetails >();

			_mutex = new Mutex( false );

			var content = GetFrontpageRequestContent( setting.InputFile );

			if( content != null )
			{
				var itemsCount = ScanDetails.Count;

				this.PerformRequest( new List< string > { content[ 0 ] } );

				if( itemsCount < ScanDetails.Count )
				{
					ScanDetails[ ScanDetails.Count - 1 ].Response += String.Format( "{0}{1}{2}", " (", content[ 1 ], ")" );
				}
			}
		}

		private static IList< string > ParseFileContent( string content )
		{
			var lines = content.Split( '\n' );
			return
				lines.Select( line => line.Replace( '\r', ' ' ) ).Select(
					clearLine =>
					( !String.IsNullOrEmpty( _scannerSetting.Folder ) ? _scannerSetting.Folder + '/' : "" ).TrimEnd() + clearLine.TrimEnd() ).ToList();
		}

		private void PerformRequest( IEnumerable< string > content )
		{
			_errorPageTitle = _scannerSetting.ErrorPageTitle;
			_errorPageBodyText = _scannerSetting.ErrorPageBodyText;
			this._threads = new List< Thread >();

			foreach( var line in content )
			{
				if( !_terminate )
				{
					//ScanResource(line);
					var thread = new Thread( ScanResource );
					this._threads.Add( thread );
					var tempLine = line;
					thread.Start( tempLine );

					if( this._threads.Count == 500 )
					{
						this.WaitForCompletedThreads();
						this._threads = new List< Thread >();
					}
				}
			}

			this.WaitForCompletedThreads();
		}

		private void WaitForCompletedThreads()
		{
			foreach( var t in this._threads )
			{
				t.Join();
			}
		}

		private static string SearchSpecificContent( string content )
		{
			var doc = new HtmlDocument();
			doc.LoadHtml( content );

			var title = doc.DocumentNode.SelectNodes( "//title" );
			var result = String.Empty;

			if( title != null )
			{
				foreach( var item in title )
				{
					result = item.InnerText.Replace( '\r', ' ' ).Replace( '\n', ' ' );
					break;
				}
			}

			return result;
		}

		private static void SearchErrorContent( ScanDetails details )
		{
			if( !String.IsNullOrEmpty( _errorPageTitle ) || !String.IsNullOrEmpty( _errorPageBodyText ) )
			{
				var doc = new HtmlDocument();
				doc.LoadHtml( details.PageTitle );

				var title = doc.DocumentNode.SelectNodes( "//title" );
				var body = doc.DocumentNode.SelectNodes( "//body" );

				if( title != null )
				{
					foreach( var item in title )
					{
						details.ErrorPageTitle = item.InnerText.Contains( _errorPageTitle ) ? "exists!" : "not found";
						break;
					}
				}

				if( body != null )
				{
					foreach( var item in body )
					{
						details.ErrorPageTitle = item.InnerText.Contains( _errorPageBodyText ) ? "exists!" : "not found";
						break;
					}
				}
			}
		}

		public static void ScanResource( object line )
		{
			var request = ConfigureRequest( _baseUrl.TrimEnd(), ( string )line );
			var details = new ScanDetails
				{
					Url = request.RequestUri
				};

			try
			{
				using( var response = ( HttpWebResponse )request.GetResponse() )
				{
					WriteResponseInfo( response, details );
				}
			}
			catch( WebException ex )
			{
				WriteResponseInfo( ( HttpWebResponse )ex.Response, details );
			}
			catch( ThreadInterruptedException )
			{
				/* Clean up. */
				ScanDetails = null;
			}
		}

		private static void WriteResponseInfo( HttpWebResponse response, ScanDetails details )
		{
			if( response != null )
			{
				try
				{
					if( ScannerSetting.GetStatusCodesList( _scannerSetting.ResponseTypes ).Contains(
						Convert.ToString( response.StatusCode ) ) )
					{
						details.Response = String.Format( "{0}{1}{2}", Convert.ToString( ( int )response.StatusCode ), ' ', response.StatusDescription );
						details.Size = response.ContentLength == -1 ? 0 : response.ContentLength;

						using( var stream = response.GetResponseStream() )
						{
							if( stream != null )
							{
								using( var reader = new StreamReader( stream, Encoding.Default ) )
								{
									if( !response.ContentType.Equals( "application/octet_stream" ) )
									{
										details.PageTitle = reader.ReadToEnd();
										details.PageBody = details.PageTitle;
									}
								}
							}
						}
						//Critical section
						//_mutex.WaitOne();
						if( response.ContentType.Contains( "text/html" ) )
						{
							SearchErrorContent( details );
							details.PageTitle = SearchSpecificContent( details.PageTitle );
						}
						else
						{
							details.PageTitle = String.Empty;
						}

						if( !String.IsNullOrEmpty( details.PageBody ) )
						{
							details.PageBody = details.PageBody.Substring( 0, 150 );
						}

						if (ScanDetails != null)
							ScanDetails.Add( details );
						//_mutex.ReleaseMutex();
					}
				}
				catch( ArgumentException )
				{
				}
			}
		}

		private static HttpWebRequest ConfigureRequest( string url, string subfolders )
		{
			AllowInvalidCertificate();

			HttpWebRequest request;

			if( _scannerSetting.WebMethod.Equals( WebRequestMethods.Http.Post ) )
			{
				url = String.Format( "{0}{1}", _baseUrl.TrimEnd(), subfolders );

				request = GetPostRequest( url, _scannerSetting.PostRequestString );
			}
			else
			{
				if( _scannerSetting.Port != 0 )
				{
					if( subfolders[ 0 ] != '/' )
					{
						subfolders = '/' + subfolders;
					}

					url = String.Format( "{0}{1}{2}{3}", url.Substring( 0, url.Length - 1 ), ":", _scannerSetting.Port, subfolders );
				}
				else
				{
					url = String.Format( "{0}{1}", _baseUrl.TrimEnd(), subfolders );
				}

				request = ( HttpWebRequest )WebRequest.Create( url );
				request.UserAgent = "Mozilla/5.0 (Windows NT 6.1; rv:5.0) Gecko/20100101 Firefox/5.0";
				request.Headers.Add( "Accept-Language", "ru-Ru" );
				request.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
                request.Method = (_scannerSetting.WebMethod == "") ? "GET" : _scannerSetting.WebMethod;

				request.KeepAlive = false;
				request.Proxy = null;
			}

			if( !String.IsNullOrEmpty( _scannerSetting.Password ) && !String.IsNullOrEmpty( _scannerSetting.Login ) )
			{
				request.Headers[ "Authorization" ] = string.Concat( "Basic ", GetBase64Credentials() );
			}

			if( !String.IsNullOrEmpty( _scannerSetting.Cookies ) )
			{
				request.Headers.Add( HttpRequestHeader.Cookie, _scannerSetting.Cookies );
			}

			return request;
		}

		private static HttpWebRequest GetPostRequest( string url, string parameters )
		{
			byte[] bytes = Encoding.ASCII.GetBytes( parameters );
			var request = ( HttpWebRequest )WebRequest.Create( url );

			request.Method = WebRequestMethods.Http.Post;
			request.ContentType = "application/x-www-form-urlencoded";
			request.ContentLength = bytes.Length;
			request.CookieContainer = _cookieContainer;
			request.KeepAlive = true;
			request.UserAgent = "Mozilla/5.0 (Windows NT 6.1; rv:5.0) Gecko/20100101 Firefox/5.0";
			request.Referer = url;

			using( var stream = request.GetRequestStream() )
			{
				stream.Write( bytes, 0, bytes.Length );
			}

			return request;
		}

		private static IEnumerable< string > GetRequestContent()
		{
			IList< string > result;

            string ppath = "";

            if (_scannerSetting.InputFile.Length > 0)
            {
                if (_scannerSetting.InputFile[0] == '\\')
                {
                    ppath = System.Windows.Forms.Application.StartupPath + _scannerSetting.InputFile;
                }
                else
                {
                    ppath = _scannerSetting.InputFile;
                }
            }

			using( var reader = new StreamReader( @ppath ) )
			{
				var content = reader.ReadToEnd();

				result = ParseFileContent( content );
			}

			if( _scannerSetting.IbmCheckEnabled )
			{
				result = AppendIbmOptions( result );
			}

			return result;
		}

		private static IList< string > AppendIbmOptions( IEnumerable< string > baseContent )
		{
			IList< string > ibmContent;
			IList< string > result = new List< string >();

			using( var reader = new StreamReader( @_scannerSetting.IbmFile ) )
			{
				var content = reader.ReadToEnd();

				ibmContent = ParseFileContent( content );
			}

			foreach( var line in baseContent )
			{
				foreach( var ibmLine in ibmContent )
				{
					result.Add( String.Format( "{0}{1}", line, ibmLine ) );
				}
			}

			return result;
		}

		private static string[] GetFrontpageRequestContent( string path )
		{
			string[] result;

            string ppath = "";

            if (path.Length > 0)
            {
                if (path[0] == '\\')
                {
                    ppath = System.Windows.Forms.Application.StartupPath + path;
                }
                else
                {
                    ppath = path;
                }
            }

			using( var reader = new StreamReader( @ppath ) )
			{
				var content = reader.ReadToEnd();
				result = content.Split( '\t' );
			}

			return result;
		}

		private static string GetBase64Credentials()
		{
			var result = string.Concat( _scannerSetting.Password, ":", _scannerSetting.Login );
			result = Convert.ToBase64String( Encoding.Default.GetBytes( result ) );

			return result;
		}

		public static void AllowInvalidCertificate()
		{
			ServicePointManager.ServerCertificateValidationCallback += AllowCert;
		}

		private static bool AllowCert( object sender, X509Certificate cert, X509Chain chain, SslPolicyErrors error )
		{
			return true;
		}

		#endregion Methods
	}

}
