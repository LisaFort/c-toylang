using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication6.src.com;

namespace ConsoleApplication6.src.domain
{
    [Serializable]
    class BoolExpt:Expr
    {
    Expr e1;
    Expr e2;
    String oper;

    /**
     * Constructor
     * @param ee1 - first expression
     * @param op - operator
     * @param ee2 - second expression
     */
    public void BoolExpr(Expr ee1, String op, Expr ee2) {
        e1 = ee1;
        e2 = ee2;
        oper = op;
    }

    /**
     * Evaluates the arithmetic expression and returns the int value
     * @param tbl
     * @return
     * @throws VarNotFound
     */
 
    public override int Eval(IDict<String, int> tbl) {
        switch(oper) {
            case "<":
                if (e1.Eval(tbl) < e2.Eval(tbl))
                {
                    return 1;
                } else {
                    return 0;
                }
            case "<=":
                if (e1.Eval(tbl) <= e2.Eval(tbl))
                {
                    return 1;
                } else {
                    return 0;
                }
            case ">":
                if (e1.Eval(tbl) > e2.Eval(tbl))
                {
                    return 1;
                } else {
                    return 0;
                }
            case ">=":
                if (e1.Eval(tbl) >= e2.Eval(tbl))
                {
                    return 1;
                } else {
                    return 0;
                }
            case "!=":
                if (e1.Eval(tbl) != e2.Eval(tbl))
                {
                    return 1;
                } else {
                    return 0;
                }
            case "==":
                if (e1.Eval(tbl) == e2.Eval(tbl))
                {
                    return 1;
                } else {
                    return 0;
                }
            default:
                    throw new UnsupportedOperationException("Unsupported operation in arithexp");
        }
    }

    public override String ToString() {
        return "( " + e1.ToString() + oper + e2.ToString() + " )";
    }
    }
}
