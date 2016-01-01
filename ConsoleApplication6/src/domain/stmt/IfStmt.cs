using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6.src.domain
{
    [Serializable]
    class IfStmt:IStmt
    {
        private Expr expr;
        private IStmt stmt1;
        private IStmt stmt2;

        /**
         * Constructor
         * @param expression - expression to be evaluated
         * @param thenS - then statement
         * @param elseS - else statement
         */
        public IfStmt(Expr e, IStmt stm1, IStmt stm2)
        {
            this.expr = e;
            this.stmt1 = stm1;
            this.stmt2 = stm2;
        }

        public Expr GetExpr
        {
            get
            {
                return expr;
            }
        }

        public IStmt GetStmt1
        {
            get
            {
                return stmt1;
            }
        }

        public IStmt GetStmt2
        {
            get
            {
                return stmt2;
            }
        }

        public override string ToString()
        {
            return "If " + expr.ToString() + " then " + stmt1.ToString() + " else " + stmt2.ToString();
        }
    }
}
