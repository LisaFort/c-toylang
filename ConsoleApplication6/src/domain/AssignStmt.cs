using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication6.src.exceptions;
using ConsoleApplication6.src.com;

namespace ConsoleApplication6.src.domain
{
    [Serializable]
    class AssignStmt:IStmt
    {
        private string id;
        private Expr expr;

        /**
         * Constructor
         * @param expression - expression
         * @param variable - variable name to assign the expression to
         */
        public AssignStmt(string str, Expr e)
        {
            this.id = str;
            this.expr = e;
        }

        public Expr GetExpr
        {
            get
            {
                return expr;
            }
        }

        public string GetId
        {
            get
            {
                return id;
            }
        }

        public override string ToString()
        {
            return id + " = " + expr.ToString();
        }

        public ProgState execute(ProgState prg)
        {
            int val = expr.Eval(prg.GetSym, prg.GetHeap );
            try
            {
                int v = prg.GetSym.Get(id);
                prg.GetSym.Modify(id, val);
            }
            catch (VariableNotFoundException v)
            {
                prg.GetSym.Add(id, val);
            }
            return null;
        }
    }
}
