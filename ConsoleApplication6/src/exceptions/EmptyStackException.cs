using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication6.src.com
{
    class EmptyStackException : Exception
    {
        public EmptyStackException(string msg)
            : base(msg)
        {

        }
    }
}
