using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6.src.domain
{
    [Serializable]
    class CompStmt:IStmt
    {
        private IStmt first;
        private IStmt second;

        public IStmt GetFirst
        {
            get
            {
                return first;
            }
        }

        public IStmt GetSecond
        {
            get
            {
                return second;
            }
        }

        /**
         * Constructor - first statement
         * @param secondstmt - second statement
         */
        public CompStmt(IStmt l, IStmt r)
        {
            this.first = l;
            this.second = r;
        }

        public override string ToString()
        {
            return "( " + first.ToString() + "; " + second.ToString() + " )";
        }

        public ProgState execute(ProgState prg)
        {
            prg.GetExe.Push(second);
            prg.GetExe.Push(first);
            return null;
        }
    }
}
