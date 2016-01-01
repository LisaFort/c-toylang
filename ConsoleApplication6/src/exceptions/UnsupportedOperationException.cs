using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication6.src.domain
{
    class UnsupportedOperationException : Exception
    {
        public UnsupportedOperationException(string msg)
            : base(msg)
        {

        }
    }
}
