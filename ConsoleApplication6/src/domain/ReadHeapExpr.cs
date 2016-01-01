using ConsoleApplication6.src.com;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6.src.domain
{
    [Serializable]
    class ReadHeapExpr:Expr
    {
        private string var;

        public ReadHeapExpr(string var) { this.var = var; }
        public override int Eval(com.IDict<string,int> dict, com.IDict<int,int> heap)
        {
            int key;
            int val;
            try
            {
                key = dict.Get(var);
            }
            catch (VariableNotFoundException e)
            {
                throw e;
            }

            try
            {
                val = heap.Get(key);
            }
            catch (VariableNotFoundException e)
            {
                throw e;
            }
            return val;
        }

        public override string ToString()
        {
            return "readExpr(" + var + ")";
        }
        
    }
}
