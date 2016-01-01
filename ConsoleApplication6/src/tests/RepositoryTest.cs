using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication6.src.com;
using ConsoleApplication6.src.domain;
using ConsoleApplication6.src.repository;
using NUnit.Framework;

namespace ConsoleApplication6.src.tests
{
    class RepositoryTest
    {
        private IRepo repo;
        public void Init()
        {
            //repo = new Repository();
            //IList<int> ot = new ArrayList<int>();
            //IDict<string, int> symtbl = new ArrayDict<string, int>();
            //IStack<IStmt> stk = new ArrayStack<IStmt>();
            //IDict<int, int> heap = new ArrayDict<int, int>();
            //IStmt stmt = new PrintStmt(new ArithExpr(new ConstExpr(3), "+", new ConstExpr(4)));
            //ot.Add(11);
            //ot.Add(12);
            //symtbl.Add("bb", 11);
            //symtbl.Add("bc", 12);
            //stk.Push(stmt);
            //ProgState prg = new ProgState(ot, symtbl, stk, heap);
            //repo.AddState(prg);

            //Assert.AreEqual(1, repo.Size());

            //ProgState prg2 = new ProgState(new ArrayList<int>(), new ArrayDict<string, int>(), new ArrayStack<IStmt>(), new ArrayDict<int,int>());
            //prg2 = repo.GetProg();
            //Assert.AreEqual(0, repo.Size());
        }
    }
}
