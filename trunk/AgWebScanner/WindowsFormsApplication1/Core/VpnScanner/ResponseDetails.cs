using System;
using System.Collections.Generic;

namespace AgWebScanner.Core.VpnScanner
{
	internal class ResponseDetails
	{
		public string Category { get; set; }
		public Uri Url { get; set; }
		public string Response { get; set; }
		public string Size { get; set; }
		public string Body { get; set; }

		public static void ClearBody( List< ResponseDetails > details, bool clearAll )
		{
			if( details != null )
			{
				if( clearAll )
				{
					foreach( var item in details )
					{
						item.Body = String.Empty;
					}
				}
				else if( details.Count != 0 )
				{
					details[ details.Count - 1 ].Body = String.Empty;
				}
			}
		}
	}
}
