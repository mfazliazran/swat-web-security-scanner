namespace AgWebScanner.Core.VpnScanner
{
	internal class ScannerSetting
	{
		public int MinId { get; set; }
		public int MaxId { get; set; }
		public bool CheckMultipleSignInPages { get; set; }
		public bool CheckWebRoot { get; set; }
		public bool CheckSetupFiles { get; set; }
		public bool CheckXssVulnerability { get; set; }
		public bool CheckAuthByPass { get; set; }
		public bool CheckAdminAccess { get; set; }
		public bool CheckMeetingTest { get; set; }
	}
}
