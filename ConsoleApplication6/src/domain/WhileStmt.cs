using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6.src.domain
{
    [Serializable]
    class WhileStmt:IStmt
    {
        private Expr exp;
        private IStmt statement;

        public WhileStmt(Expr exp, IStmt thenStatement) {
            this.exp = exp;
            this.statement = thenStatement;
        }

        public Expr getExpr() {
            return exp;
        }

        public IStmt getStmt() {
            return statement;
        }

        public override String ToString() {
            return "WHILE " + exp.ToString() + " THEN(" + statement.ToString() + ") ";
        }

        public ProgState execute(ProgState prg)
        {
            int val = exp.Eval(prg.GetSym, prg.GetHeap);
            if (val != 0)
            {
                prg.GetExe.Push(this);
                prg.GetExe.Push(statement);
               
            }
            return null;
        }

    }
    }
