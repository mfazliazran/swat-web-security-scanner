using System;

namespace AgWebScanner.Core.Scanner
{
	public class ScanDetails
	{
		public Uri Url { get; set; }
		public string Response { get; set; }
		public long Size { get; set; }
		public string PageTitle { get; set; }
		public string PageBody { get; set; }
		public string ErrorPageTitle { get; set; }
		public string ErrorPageBody { get; set; }
	}
}
