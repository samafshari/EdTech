using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyler.Models
{
    public struct FileMapping
    {
        public string A;
        public string B;

        public FileMapping(string s)
        {
            A = s;
            B = Path.GetFileName(s);
        }

        public FileMapping(string a, string b)
        {
            A = a;
            B = b;
        }

        override public string ToString()
        {
            return $"{A} -> {B}";
        }
    }
}
