using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AgWebScanner.Core.HttpScan
{
    public class Command
    {
        public bool AddToConsole { get; set; }
        public List<string> AddToConsoleStr { get; set; }
        public List<System.Drawing.Color> AddToConsoleColor { get; set; }

        public Command()
        {
            AddToConsoleStr = new List<string>();
            AddToConsoleColor = new List<System.Drawing.Color>();
        }
    }
}
