using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication6.src.com;
using ConsoleApplication6.src.exceptions;

namespace ConsoleApplication6.src.domain
{
    [Serializable]
    class ArithExpr:Expr
    {
        private Expr e1;
        private Expr e2;
        private string op;

        /**
        * Constructor
        * @param ee1 - first expression
        * @param op - operator
        * @param ee2 - second expression
        */
        public ArithExpr(Expr ex1, string oper, Expr ex2)
        {
            this.e1 = ex1;
            this.e2 = ex2;
            this.op = oper;
        }

        public Expr GetE1
        {
            get
            {
                return e1;
            }
        }

        public Expr GetE2
        {
            get
            {
                return e2;
            }
        }

        public string GetOp
        {
            get
            {
                return op;
            }
        }

        /**
        * Evaluates the arithmetic expression and returns the int value
        * @param tbl
        * @return
        * @throws VarNotFound
        */
        public override int Eval(IDict<string, int> dict, IDict<int, int> heap)
        {
            switch (op)
            {
                case "+":
                    return e1.Eval(dict, heap) + e2.Eval(dict, heap);
                case "*":
                    return e1.Eval(dict, heap) * e2.Eval(dict, heap);
                case "-":
                    return e1.Eval(dict, heap) - e2.Eval(dict, heap);
                case "/":
                    if (e1.Eval(dict, heap) == 0 || e2.Eval(dict, heap) == 0)
                    {
                        throw new DivByZeroException("Cannot divide by zero");
                    }
                    return e1.Eval(dict, heap) - e2.Eval(dict, heap);
                default:
                    throw new UnsupportedOperationException("Unsupported operation in arithexp");
            }
        }

        public override string ToString()
        {
            return e1.ToString() + " " + op + " " + e2.ToString();
        }
    }
}
