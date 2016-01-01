using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication6.src.com;
using ConsoleApplication6.src.domain;
using NUnit.Framework;

namespace ConsoleApplication6.src.tests
{
    class ProgStateTest
    {
        private ProgState prg;

        public void Init()
        {
            IList<int> ot = new ArrayList<int>();
            IDict<string, int> symtbl = new ArrayDict<string, int>();
            IDict<int, int> heap = new ArrayDict<int, int>();
            IStack<IStmt> stk = new ArrayStack<IStmt>();
            IStmt stmt = new PrintStmt(new ArithExpr(new ConstExpr(3), "+", new ConstExpr(4)));
            ot.Add(11);
            ot.Add(12);
            symtbl.Add("bb", 11);
            symtbl.Add("bc", 12);
            stk.Push(stmt);
            prg = new ProgState(ot, symtbl, stk,heap);

            Assert.AreEqual("[ print( 3 + 4 ) ]", prg.ToStrExe());
            Assert.AreEqual("[ 11, 12 ]", prg.ToStrOut());
            Assert.AreEqual("[ bb:11, bc:12 ]", prg.ToStrSym());
        }
    }
}
