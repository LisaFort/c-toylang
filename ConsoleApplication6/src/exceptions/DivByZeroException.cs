using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6.src.exceptions
{
    class DivByZeroException:Exception
    {
        public DivByZeroException(string msg):base (msg)
        {

        }
    }
}
