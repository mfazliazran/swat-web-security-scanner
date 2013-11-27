using System;

namespace AgWebScanner.Core.UsernameEnumerator
{
    class ResponseDetails
    {
        public string UserName { get; set; }
        public string SearchResult { get; set; }
        public string Response { get; set; }
        public Uri Url { get; set; }
    }
}
