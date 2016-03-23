using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginAppClient
{
    class Log
    {
        public static string FileName { get; set; }

        public static void Write(string line)
        {
            StreamWriter file = new StreamWriter(FileName, true);

            file.WriteLine(string.Format("{0} {1}", DateTime.Now, line));

            file.Close();
        }

        private Log() { }
    }
}
