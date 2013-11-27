using System.Collections.Generic;

namespace AgWebScanner.Core.UsernameEnumerator
{
    class UsernameEnumeratorSetting
    {
        public string Method { get; set; }
        public string TextToSearch { get; set; }
        public string UrlParameters { get; set; }
        public string UserNameKey { get; set; }
        public List<string> UserNames { get; set; }
        public List<string> ParamStrings { get; set; }
    }
}
