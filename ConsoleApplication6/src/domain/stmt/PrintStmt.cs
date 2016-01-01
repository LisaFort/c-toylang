using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6.src.domain
{
    [Serializable]
    class PrintStmt:IStmt
    {
        private Expr expr;

        /**
         * Constructor
         * @param e
         */
        public PrintStmt(Expr e)
        {
            this.expr = e;
        }

        public Expr GetExpr
        {
            get
            {
                return expr;
            }
        }

        public override string ToString()
        {
            return "print( " + expr.ToString() + " )";
        }
    }
}
