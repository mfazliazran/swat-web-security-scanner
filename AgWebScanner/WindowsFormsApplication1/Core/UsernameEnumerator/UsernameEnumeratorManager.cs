using System;
using System.IO;
using System.Threading;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using HtmlAgilityPack;

namespace AgWebScanner.Core.UsernameEnumerator
{
	internal class UsernameEnumeratorManager : IDisposable
	{
		#region Fields

		public static List< ResponseDetails > ResponseDetails { get; set; }
		public UsernameEnumeratorSetting _setting { get; set; }
		private static string WebMethod { get; set; }
		private static string UserNameKey { get; set; }
		private static string _baseUrl;
		private List< Thread > _threads;
		private static CookieContainer _cookieContainer;
		private static volatile bool _terminate;

		#endregion Fields

		#region Constructors

		public UsernameEnumeratorManager( string baseUrl )
		{
			_baseUrl = baseUrl;
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

				ResponseDetails = null;
			}
		}

		public static string GetResultForExport()
		{
			var result = new StringBuilder();

			foreach( var item in ResponseDetails )
			{
				result.Append( String.Format( "{0}{1}{2}", item.Url, '\t', item.Response ) );
			}

			return result.ToString();
		}

		public void CheckResource( UsernameEnumeratorSetting setting )
		{
			if( String.IsNullOrEmpty( _baseUrl ) )
			{
				return;
			}

			this._setting = setting;
			ResponseDetails = new List< ResponseDetails >();

			WebMethod = this._setting.Method;
			UserNameKey = this._setting.UserNameKey;
			_cookieContainer = new CookieContainer();
			this.PerformRequest();
		}

		private void PerformRequest()
		{
			this._threads = new List< Thread >();
			for( var i = 0; i < this._setting.UserNames.Count; i++ )
			{
				if( !_terminate )
				{
					var url = String.Format( "{0}{1}", _baseUrl, this._setting.ParamStrings[ i ] );
					var request = WebMethod.Equals( WebRequestMethods.Http.Get ) ? ConfigureGetRequest( url ) : ConfigurePostRequest( _baseUrl.Replace( '?', ' ' ).Trim(), _setting.ParamStrings[ i ] );

					var thread = new Thread( ScanResource );
					this._threads.Add( thread );
					var userName = this._setting.UserNames[ i ];
					var tempRequest = new List< object > { userName, request };
					thread.Start( tempRequest );

					if( this._threads.Count == 500 )
					{
						this.WaitForCompletedThreads();
						this._threads = new List< Thread >();
					}
				}

				this.WaitForCompletedThreads();
			}

			foreach( var item in ResponseDetails )
				this.SearchSpecificContent( item, this._setting.TextToSearch );
		}

		private void WaitForCompletedThreads()
		{
			foreach( var t in this._threads )
			{
				t.Join();
			}
		}

		public static void ScanResource( object request )
		{
			var values = ( List< object > )request;
			var castedRequest = ( HttpWebRequest )values[ 1 ];
			var details = new ResponseDetails
				{
					Url = castedRequest.RequestUri,
					UserName = ( string )values[ 0 ]
				};

			try
			{
				using( var response = ( HttpWebResponse )castedRequest.GetResponse() )
				{
					foreach( Cookie cookie in response.Cookies )
					{
						_cookieContainer.Add( response.ResponseUri, cookie );
					}

					WriteResponseInfo( response, details );
					response.Close();
				}

			}
			catch( WebException ex )
			{
				WriteResponseInfo( ( HttpWebResponse )ex.Response, details );
			}
		}

		private static void WriteResponseInfo( HttpWebResponse response, ResponseDetails details )
		{
			details.Response = String.Format( "{0}{1}{2}", Convert.ToString( ( int )response.StatusCode ), ' ', response.StatusDescription );

			using( var reader = new StreamReader( response.GetResponseStream(), Encoding.ASCII ) )
			{
				details.SearchResult = reader.ReadToEnd();
			}

			if( ResponseDetails != null )
			{
				ResponseDetails.Add( details );
			}
		}

		private static HttpWebRequest ConfigurePostRequest( string url, string parameters )
		{
			if( url.Contains( "https" ) )
			{
				AllowInvalidCertificate();
			}

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

		private static HttpWebRequest ConfigureGetRequest( string url )
		{
			if( url.Contains( "https" ) )
			{
				AllowInvalidCertificate();
			}

			var request = ( HttpWebRequest )WebRequest.Create( url );
			request.UserAgent = "Mozilla/5.0 (Windows NT 6.1; rv:5.0) Gecko/20100101 Firefox/5.0";
			request.Headers.Add( "Accept-Language", "ru-Ru" );
			request.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
			request.Method = WebRequestMethods.Http.Get;
			request.KeepAlive = false;
			request.Proxy = null;
			request.Credentials = CredentialCache.DefaultCredentials;

			return request;
		}

		private void SearchSpecificContent( ResponseDetails details, string searchText )
		{
			var doc = new HtmlDocument();
			doc.LoadHtml( details.SearchResult );

			var body = doc.DocumentNode.SelectNodes( "//body" );
			var title = doc.DocumentNode.SelectNodes( "//title" );
			var resultCopy = details.SearchResult;
			details.SearchResult = "Not Found";

			if( this.IsTextExists( body, searchText ) || this.IsTextExists( title, searchText ) )
			{
				details.SearchResult = "Exists";
			}
			else if( resultCopy.Contains( searchText ) )
			{
				details.SearchResult = "Exists";
			}
		}

		private bool IsTextExists( IEnumerable< HtmlNode > nodes, string searchText )
		{
			var result = false;
			if( nodes != null )
			{
				foreach( var item in nodes )
				{
					if( item.InnerText.Contains( searchText ) )
					{
						result = true;
						break;
					}
				}
			}
			return result;
		}

		#region https_hack

		public static void AllowInvalidCertificate()
		{
			ServicePointManager.ServerCertificateValidationCallback += allowCert;
		}

		private static bool allowCert( object sender, X509Certificate cert, X509Chain chain, SslPolicyErrors error )
		{
			return true;
		}

		#endregion https_hack

		#endregion Methods
	}
}
