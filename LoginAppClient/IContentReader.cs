using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginAppClient
{
    interface IContentReader
    {
        string ReadFullContent(string fileName);
    }
}
