using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeStore
{
    class connectionclass
    {
        public string address = System.IO.File.ReadAllText(@"C:\Test.txt");
    }
}
