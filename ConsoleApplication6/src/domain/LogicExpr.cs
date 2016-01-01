using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication6.src.com;

namespace ConsoleApplication6.src.domain
{
    [Serializable]
    class LogicExpr:Expr
    {
        Expr e1;
        Expr e2;
        String oper;

        /**
         * Constructor
         *
         * @param ee1 - first expression
         * @param op  - operator
         * @param ee2 - second expression
         */
        public LogicExpr(Expr ee1, String op, Expr ee2) {
            e1 = ee1;
            e2 = ee2;
            oper = op;
        }

        /**
         * Evaluates the arithmetic expression and returns the int value
         *
         * @param tbl
         * @return
         * @throws VarNotFound
         */
        public override int Eval(IDict<String, int> tbl, IDict<int,int> heap) {
            if (oper == "||") {
                int ev1 = e1.Eval(tbl, heap);
                int ev2 = e2.Eval(tbl, heap);
                bool b1, b2;
                if (ev1 == 0) {
                    b1 = false;
                } else b1 = true;
                if (ev2 == 0) {
                    b2 = false;
                } else b2 = true;
                bool b3 = b1 || b2;
                if (b3 == false) {
                    return 0;
                } else return 1;
            }
            if (oper == "&&" ) {
                int ev1 = e1.Eval(tbl, heap);
                int ev2 = e2.Eval(tbl, heap);
                bool b1, b2;
                if (ev1 == 0) {
                    b1 = false;
                } else b1 = true;
                if (ev2 == 0) {
                    b2 = false;
                } else b2 = true;
                bool b3 = b1 && b2;
                if (b3 == false) {
                    return 0;
                } else return 1;
            }
            if (oper == "!") {
                int ev1 = e1.Eval(tbl, heap);
                bool b1;
                if (ev1 == 0) {
                    b1 = false;
                } else b1 = true;
                if (b1 == false) {
                    return 1;
                } else return 0;
            }
            else
            {
                throw new UnsupportedOperationException("Wrong operator ");
            }
        }


        public override String ToString() {
            if (oper == "!") {
                return "!(" + e1.ToString() + ")";
            } else {
                return "( " + e1.ToString() + oper + e2.ToString() + " )";
            }
        }
    }
}
