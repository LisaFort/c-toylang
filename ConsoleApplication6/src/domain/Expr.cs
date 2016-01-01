using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication6.src.com;

namespace ConsoleApplication6.src.domain
{
    [Serializable]
    abstract class Expr
    {
        public abstract int Eval(IDict<string, int> dict, IDict<int, int> heap);
        public override abstract string ToString();
    }
}
