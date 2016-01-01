using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6.src.domain
{
    [Serializable]
    class NewHeapStmt:IStmt
    {
        private string var;
        private Expr exp;

        public NewHeapStmt(String var, Expr exp)
        {
            this.var = var;
            this.exp = exp;
        }

        public ProgState execute(ProgState prg)
        {
            int key;
            if (prg.GetHeap == null)
            {
                key = 1;
            }
            else
            {
                key = prg.GetHeap.Size() + 1;
            }
            prg.GetHeap.Add(key, exp.Eval(prg.GetSym, prg.GetHeap));
            try
            {
                prg.GetSym.Add(var, key);
            }
            catch (ArgumentException a)
            {
                prg.GetSym.Modify(var, key);
            }
            return null;
        }

        public override string ToString()
        {
            return "new( " + var + "," + exp.ToString() + ")";
        }
    }
}
