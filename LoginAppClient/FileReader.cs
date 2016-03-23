using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginAppClient
{
    class FileReader : IContentReader
    {
        public string ReadFullContent(string fileName)
        {
            return System.IO.File.ReadAllText(fileName);
        }
    }
}
