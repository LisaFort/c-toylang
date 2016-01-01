using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6.src.domain
{
    [Serializable]
    class SwitchStmt:IStmt
    {
        VarExpr var;
        Expr exp1;
        Expr exp2;
        IStmt stm1;
        IStmt stm2;
        IStmt stm3;

        public SwitchStmt(Expr ex1, Expr ex2, VarExpr varn, IStmt st1 ,IStmt st2, IStmt st3) {
            var = varn;
            exp1 = ex1;
            exp2 = ex2;
            stm1 = st1;
            stm2 = st2;
            stm3 = st3;
        }

        public IStmt getStm3() {
            return stm3;
        }

        public IStmt getStm2() {

            return stm2;
        }

        public IStmt getStm1() {

            return stm1;
        }

        public Expr getExp2() {

            return exp2;
        }

        public Expr getExp1() {

            return exp1;
        }

        public VarExpr getVar() {
            return var;
        }

        public override String ToString() {
            return "Switch (" + var.ToString() + ") case (" +  exp1.ToString() +"): " + stm1.ToString() + "case (" +  exp2.ToString() +"):" + stm2.ToString() + "default: " + stm3.ToString();
        }

        public ProgState execute(ProgState prg)
        {
            IfStmt istmt = new IfStmt(new ArithExpr(var, "-", exp2), new IfStmt(new ArithExpr(var, "-", exp1), stm3, stm1), stm2);
            prg.GetExe.Push(istmt);
            return null;
        }
    }
}
