using System;
using System.Globalization;
using System.IO;
using System.Threading;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using HtmlAgilityPack;

namespace AgWebScanner.Core.VpnScanner
{
	internal class JuniperManager : IDisposable
	{
		#region Fields

		public static List< ResponseDetails > ResponseDetails { get; set; }
		public static ResponseSummary ResponseSummary { get; set; }
		private static List< string > _existingSignInUrls;
		private static Mutex _mutex;
		private static string _baseUrl;
		private List< Thread > _threads;
		private static CookieContainer CookieContainer;
		private static volatile bool _terminate;

		//test urls
		private readonly string _adminAccessUrl;
		private readonly string _firstFileUrl;
		private readonly string _secondFileUrl;
		private readonly string _meetingUrl;
		private readonly string _firstRemediateUrl;
		private readonly string _secondRemediateUrl;
		private readonly string _defaultAttackUrl;
		private readonly string _authByPassUrl;
		private readonly string _xssVulnerabilityUr;
		private readonly string _cXssVulnerabilityUr;
		private readonly string _dXssVulnerabilityUr;
		private readonly string _eXssVulnerabilityUr;
		private readonly string _fXssVulnerabilityUr;
		private readonly string _gXssVulnerabilityUr;

		#endregion Fields

		#region Constructors

		public JuniperManager( string baseUrl )
		{
			_baseUrl = baseUrl;
			this._adminAccessUrl = String.Format( "{0}{1}", _baseUrl, Properties.Settings.Default.AdminAccessUrlPart );
			this._firstFileUrl = String.Format( "{0}{1}", _baseUrl, Properties.Settings.Default.FirstFileUrlPart );
			this._secondFileUrl = String.Format( "{0}{1}", _baseUrl, Properties.Settings.Default.SecondFileUrlPart );
			this._meetingUrl = String.Format( "{0}{1}", _baseUrl, Properties.Settings.Default.Meeting );
			this._firstRemediateUrl = String.Format( "{0}{1}", _baseUrl, Properties.Settings.Default.FirstRemediateCgiUrlPart );
			this._secondRemediateUrl = String.Format( "{0}{1}", _baseUrl, Properties.Settings.Default.SecondRemediateCgiUrlPart );
			this._defaultAttackUrl = String.Format( "{0}{1}", _baseUrl, Properties.Settings.Default.ScriptingAttacksUrlPartDefault );
			this._authByPassUrl = String.Format( "{0}{1}", _baseUrl, Properties.Settings.Default.AuthByPassUrlPart );
			this._xssVulnerabilityUr = String.Format( "{0}{1}", _baseUrl, Properties.Settings.Default.XssVulnerabilityUrlPart );
			this._cXssVulnerabilityUr = String.Format( "{0}{1}", _baseUrl, Properties.Settings.Default.CXssVulnerabilityUrlPart );
			this._dXssVulnerabilityUr = String.Format( "{0}{1}", _baseUrl, Properties.Settings.Default.DXssVulnerabilityUrlPart );
			this._eXssVulnerabilityUr = String.Format( "{0}{1}", _baseUrl, Properties.Settings.Default.EXssVulnerabilityUrlPart );
			this._fXssVulnerabilityUr = String.Format( "{0}{1}", _baseUrl, Properties.Settings.Default.FXssVulnerabilityUrlPart );
			this._gXssVulnerabilityUr = String.Format( "{0}{1}", _baseUrl, Properties.Settings.Default.GBXssVulnerabilityUrlPart );
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
				_existingSignInUrls = null;
				ResponseSummary = null;
			}
		}

		public static string GetResultForExport()
		{
			var result = new StringBuilder();

			foreach( var item in ResponseDetails )
			{
				result.Append( String.Format( "{0}{1}{2}{3}{4}{5}", item.Url, '\t', item.Response, '\t', item.Size, '\n' ) );
			}

			return result.ToString();
		}

		public void CheckResource( ScannerSetting setting )
		{
			if( String.IsNullOrEmpty( _baseUrl ) )
			{
				return;
			}

			ResponseDetails = new List< ResponseDetails >();
			ResponseSummary = new ResponseSummary();
			_existingSignInUrls = new List< string >();
			_mutex = new Mutex( false );


			this.PerformTests( setting );
		}

		public void CheckResource( AttackSettings attackSettings )
		{
			ResponseDetails = new List< ResponseDetails >();
			_mutex = new Mutex( false );

			this.PerformDictionaryAttack( attackSettings );
		}

		private void PerformDictionaryAttack( AttackSettings attackSettings )
		{
			for( var i = 0; i < attackSettings.AttackParams.Count; i++ )
			{
				var request = ConfigurePostRequest( attackSettings.AttackUrl, attackSettings.AttackParams[ i ] );
				ResponseSummary.SignInGeneratedUrls.Add( attackSettings.AttackUrl + attackSettings.AttackParams[ i ] );

				ScanResource( request );
			}
		}

		private void PerformTests( ScannerSetting setting )
		{
			if( ResponseSummary == null )
			{
				return;
			}

			if( setting.CheckMultipleSignInPages )
			{
				this.PerformMultiplySignInPagesTest( setting );

				ResponseSummary.SignInPagesOk = this.CollectSummaryItem( Categories.SignInPages, true );

				VpnScanner.ResponseDetails.ClearBody( ResponseDetails, true );
			}

			if( setting.CheckAdminAccess )
			{
				this.PerformAdminAccessTest();

				ResponseSummary.AdminAccessOk = this.CollectSummaryItem( Categories.AdminAccess, false );
			}

			if( setting.CheckMeetingTest )
			{
				this.PerformCheckMeetingTest();

				ResponseSummary.MeetingTestOk = this.CollectSummaryItem( Categories.MeetingTest, false );
			}

			if( setting.CheckXssVulnerability )
			{
				this.PerformScriptingAttacksTest();

				this.PerformXssVulnerabilityTests();

				ResponseSummary.XssTestOk = this.CollectSummaryItem( Categories.XssTest, true );
			}

			if( setting.CheckSetupFiles )
			{
				this.PerformCheckFilesExistenceTest();

				ResponseSummary.SetupFilesOk = this.CollectSummaryItem( Categories.SetupFiles, true );
			}

			if( setting.CheckWebRoot )
			{
				this.PerformCheckWebRootTest();

				ResponseSummary.WebRootOk = this.CollectSummaryItem( Categories.WebRoot, false );
			}

			if( setting.CheckAuthByPass )
			{
				this.PerformAuthByPassTest();

				ResponseSummary.AuthByPassOk = this.CollectSummaryItem( Categories.AuthByPass, false );
			}
		}

		public static void ScanResource( object request )
		{
			var castedRequest = ( HttpWebRequest )request;
			var details = new ResponseDetails
				{
					Url = castedRequest.RequestUri,
					Category = Categories.SignInPages
				};

			try
			{
				using( var response = ( HttpWebResponse )castedRequest.GetResponse() )
				{
					foreach( Cookie cookie in response.Cookies )
					{
						CookieContainer.Add( response.ResponseUri, cookie );
					}

					WriteResponseInfo( response, details );
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
			details.Size = response.ContentLength == -1 ? "Not Presented" : response.ContentLength.ToString( CultureInfo.InvariantCulture );

			using( var stream = response.GetResponseStream() )
			{
				using( var reader = new StreamReader( stream, Encoding.Default ) )
				{
					details.Body = reader.ReadToEnd();
				}
			}

			if( ResponseDetails != null )
			{
				//Critical section
				_mutex.WaitOne();
				ResponseDetails.Add( details );
				_mutex.ReleaseMutex();
			}
		}

		private static HttpWebRequest ConfigurePostRequest( string url, string parameters )
		{
			AllowInvalidCertificate();

			var postUrl = url.Replace( '?', ' ' ).Trim();

			byte[] bytes = Encoding.ASCII.GetBytes( parameters );
			var request = ( HttpWebRequest )WebRequest.Create( postUrl );

			request.Method = WebRequestMethods.Http.Post;
			request.ContentType = "application/x-www-form-urlencoded";
			request.ContentLength = bytes.Length;
			request.CookieContainer = CookieContainer;
			request.KeepAlive = true;
			request.UserAgent = "Mozilla/5.0 (Windows NT 6.1; rv:5.0) Gecko/20100101 Firefox/5.0";
			request.Referer = postUrl;

			using( var stream = request.GetRequestStream() )
			{
				stream.Write( bytes, 0, bytes.Length );
			}

			return request;
		}

		private static HttpWebRequest ConfigureGetRequest( Uri url )
		{
			AllowInvalidCertificate();
			var request = ( HttpWebRequest )WebRequest.Create( url );
			request.UserAgent = "Mozilla/5.0 (Windows NT 6.1; rv:5.0) Gecko/20100101 Firefox/5.0";
			request.Headers.Add( "Accept-Language", "ru-Ru" );
			request.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
			request.Method = "GET";
			request.KeepAlive = false;
			request.Proxy = null;
			request.Credentials = CredentialCache.DefaultCredentials;

			return request;
		}

		private void CollectOkAnswers()
		{
			foreach( var item in ResponseDetails )
			{
				if( item.Response.Contains( "200" ) && item.Category.Equals( Categories.SignInPages ) )
				{
					_existingSignInUrls.Add( item.Url.ToString() );
				}
			}
		}

		private bool CollectSummaryItem( string category, bool checkForMultiplyExistence )
		{
			var result = false;

			if( ResponseDetails != null )
			{
				int counter = 0;
				foreach( var item in ResponseDetails )
				{
					if( item.Category.Equals( category ) && item.Response.Contains( "200" ) )
					{
						result = true;
						counter++;

						if( !checkForMultiplyExistence )
						{
							break;
						}
						if( checkForMultiplyExistence &&
						    counter > 1 &&
						    category.Equals( Categories.SignInPages ) )
						{
							result = false;
							break;
						}
						if( checkForMultiplyExistence &&
						    counter > 1 &&
						    category.Equals( Categories.SetupFiles ) )
						{
							break;
						}
					}
					else if( item.Category.Equals( category )
					         && !item.Response.Contains( "200" )
					         && checkForMultiplyExistence
					         && !item.Category.Equals( Categories.SignInPages ) )
					{
						break;
					}
				}
			}

			return result;
		}

		#region Tests

		private void PerformMultiplySignInPagesTest( ScannerSetting setting )
		{
			this._threads = new List< Thread >();

			for( int i = setting.MinId; i < setting.MaxId; i++ )
			{
				if( !_terminate )
				{
					var url = String.Format( "{0}{1}", _baseUrl, Properties.Settings.Default.CheckByIdUrlPart ).Replace( "$URLID", i.ToString( CultureInfo.InvariantCulture ) );
					var completedUrl = new Uri( url );
					var request = ConfigureGetRequest( completedUrl );

					var thread = new Thread( ScanResource );
					this._threads.Add( thread );
					thread.Start( request );

					ResponseSummary.SignInGeneratedUrls.Add( url );

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

		private void PerformAdminAccessTest()
		{
			this.PerformSpecificTest( this._adminAccessUrl, "Administrator Sign-In Page", "body", Categories.AdminAccess );
		}

		private void PerformAuthByPassTest()
		{
			var request = ConfigureGetRequest( new Uri( this._authByPassUrl ) );
			ScanResource( request );

			ResponseDetails[ ResponseDetails.Count - 1 ].Category = Categories.AuthByPass;
			VpnScanner.ResponseDetails.ClearBody( ResponseDetails, false );
		}

		private void PerformScriptingAttacksTest()
		{
			//checking url_default
			this.PerformSpecificTest( this._defaultAttackUrl, "alert(1)", "script", Categories.XssTest );

			//checking existing url
			this.CollectOkAnswers();

			if( _existingSignInUrls.Count != 0 )
			{
				foreach( var item in _existingSignInUrls )
				{
					var url = String.Format( "{0}{1}", item, Properties.Settings.Default.ScriptingAttackUrlPartCustom );
					this.PerformSpecificTest( url, "alert(1)", "script", Categories.XssTest );
				}
			}
		}

		private void PerformXssVulnerabilityTests()
		{
			this.PerformSpecificTest( this._xssVulnerabilityUr, "alert(document.cookie)", "script", Categories.XssTest );
			this.PerformSpecificTest( this._cXssVulnerabilityUr, "alert(999)", "script", Categories.XssTest );
			this.PerformSpecificTest( this._dXssVulnerabilityUr, "alert(999)", "script", Categories.XssTest );
			this.PerformSpecificTest( this._eXssVulnerabilityUr, "alert(999)", "script", Categories.XssTest );
			this.PerformSpecificTest( this._fXssVulnerabilityUr, "alert(999)", "script", Categories.XssTest );
			this.PerformSpecificTest( this._gXssVulnerabilityUr, "alert(999)", "script", Categories.XssTest );
		}

		private void PerformCheckMeetingTest()
		{
			VpnScanner.ResponseDetails.ClearBody( ResponseDetails, false );
			this.PerformSpecificTest( this._meetingUrl, "Meeting User Sign-In Page.", "body", Categories.MeetingTest );
		}

		private void PerformCheckFilesExistenceTest()
		{
			var request = ConfigureGetRequest( new Uri( this._firstFileUrl ) );
			ScanResource( request );
			VpnScanner.ResponseDetails.ClearBody( ResponseDetails, false );
			ResponseDetails[ ResponseDetails.Count - 1 ].Category = Categories.SetupFiles;

			request = ConfigureGetRequest( new Uri( this._secondFileUrl ) );
			ScanResource( request );
			VpnScanner.ResponseDetails.ClearBody( ResponseDetails, false );
			ResponseDetails[ ResponseDetails.Count - 1 ].Category = Categories.SetupFiles;
		}

		private void PerformCheckWebRootTest()
		{
			this.PerformSpecificTest( this._firstRemediateUrl, "500 Internal Error", "H2", Categories.WebRoot );
			this.PerformSpecificTest( this._secondRemediateUrl, "500 Internal Error", "H2", Categories.WebRoot );
		}

		private void PerformSpecificTest( string url, string searchText, string searchTag, string category )
		{
			var request = ConfigureGetRequest( new Uri( url ) );
			ScanResource( request );

			if( ResponseDetails == null )
			{
				return;
			}

			var details = ResponseDetails[ ResponseDetails.Count - 1 ];
			details.Category = category;

			SearchSpecificContent( details, searchText, searchTag );
		}

		private static void SearchSpecificContent( ResponseDetails details, string searchText, string searchTag )
		{
			var doc = new HtmlDocument();
			doc.LoadHtml( details.Body );

			var body = doc.DocumentNode.SelectNodes( String.Format( "{0}{1}", "//", searchTag ) );
			details.Body = "Did not exists";

			if( body != null )
			{
				foreach( var item in body )
				{
					if( item.InnerText.Contains( searchText ) )
					{
						details.Body = String.Format( "{0}{1}", searchText, " exists" );
						break;
					}
				}
			}
		}

		#endregion Tests

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
