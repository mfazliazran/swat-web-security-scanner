using System.Collections.Generic;

namespace AgWebScanner.Core.VpnScanner
{
	internal class AttackSettings
	{
		public List< string > AttackParams { get; set; }
		public string AttackUrl { get; set; }

		public AttackSettings()
		{
			this.AttackParams = new List< string >();
		}
	}
}
