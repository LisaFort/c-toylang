using ConsoleApplication6.src.com;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6.src.domain
{
    [Serializable]
    class WriteHeapStmt:IStmt
    {
        private string var;
        private Expr exp;

        public WriteHeapStmt(string var, Expr exp)
        {
            this.var = var;
            this.exp = exp;
        }

        public ProgState execute(ProgState prg)
        {
            int key ;
            try
            {
                key = prg.GetSym.Get(var);
            }
            catch (VariableNotFoundException v)
            {
                throw v;
            }
            try
            {
                prg.GetHeap.Add(key, exp.Eval(prg.GetSym, prg.GetHeap));
            }
            catch (ArgumentException a)
            {
                prg.GetHeap.Modify(key, exp.Eval(prg.GetSym, prg.GetHeap));
            }
            return null;
        }

        public override string ToString()
        {
            return "wH(" + var + "," + exp.ToString() + ")";
        }
    }
}
