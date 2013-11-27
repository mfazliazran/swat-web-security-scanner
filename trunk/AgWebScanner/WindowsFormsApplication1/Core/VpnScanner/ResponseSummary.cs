using System.Collections.Generic;

namespace AgWebScanner.Core.VpnScanner
{
	internal class ResponseSummary
	{
		public bool SignInPagesOk { get; set; }
		public bool AdminAccessOk { get; set; }
		public bool WebRootOk { get; set; }
		public bool SetupFilesOk { get; set; }
		public bool AuthByPassOk { get; set; }
		public bool MeetingTestOk { get; set; }
		public bool XssTestOk { get; set; }
		public List< string > SignInGeneratedUrls { get; set; }

		public ResponseSummary()
		{
			this.SignInGeneratedUrls = new List< string >();
		}
	}
}
