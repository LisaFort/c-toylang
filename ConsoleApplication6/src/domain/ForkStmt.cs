using ConsoleApplication6.src.com;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6.src.domain
{
    [Serializable]
    class ForkStmt:IStmt
    {
        IStmt stm;

        public ForkStmt(IStmt st) {
            stm = st;
        }

        public IStmt GetStmt() { return stm; }

        public override String ToString() { return "fork( " + stm.ToString() + ")"; }

        public ProgState execute (ProgState prg) {
            IStack<IStmt> stk = new ArrayStack<IStmt>();
            stk.Push(stm);
            IDict<string, int> dict  = new ArrayDict<string, int>();
            int i = 0;
            List<string> keys = new List<string>(prg.GetSym.GetKeys());

            int j = prg.GetSym.Size();
            while ( i < j) {
                dict.Add(keys.ElementAt(i), prg.GetSym.Get(keys.ElementAt(i)));
                i++;
            }

            com.IList<int> outer = prg.GetOut;
            IDict<int, int> heap = prg.GetHeap;
            ProgState prgg = new ProgState(outer,dict,stk,heap);
            return prgg;

        }
    }
}
