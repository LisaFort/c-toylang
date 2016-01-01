using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6.src.domain
{
    [Serializable]
    class IfThenStmt:IStmt
    {
        private Expr exp;
        private IStmt thenStmt;

        /**
         * Constructor
         * @param expression - expression to be evaluated
         * @param thenS - else statement
         */
        public IfThenStmt(Expr expression,  IStmt thenS) {
            exp = expression;
            thenStmt = thenS;
        }

        public IStmt getThenStmt() {

            return thenStmt;
        }

        public Expr getExpr() {

            return exp;
        }

        public override String ToString() {
            return "if ( " + exp.ToString() + " ) then ( " + thenStmt.ToString() + ")";
        }

        public override ProgState execute(ProgState prg)
        {
            IStmt iss = new IfStmt(exp, thenStmt, new SkipStmt());
            prg.GetExe.Push(iss);
            return null;
        }
    }
}
