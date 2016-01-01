using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication6.src.com;

namespace ConsoleApplication6.src.domain
{
    [Serializable]
    class ConstExpr:Expr 
    {
        private int nr;

        /**
         * Constructor
         * @param number - integer
         */
        public ConstExpr(int number)
        {
            this.nr = number;
        }

        public int GetNr
        {
            get
            {
                return nr;
            }
        }

        public override int Eval(IDict<string, int> dict) {
            return nr;
        }

        public override string ToString()
        {
            return nr.ToString();
        }
    }
}
