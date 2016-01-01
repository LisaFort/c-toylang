using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication6.src.com
{
    class VariableNotFoundException : Exception
    {
        public VariableNotFoundException(string msg):base (msg) {

        }
    }
}
