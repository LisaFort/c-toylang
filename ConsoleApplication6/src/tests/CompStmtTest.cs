using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ConsoleApplication6.src.domain;

namespace ConsoleApplication6.src.tests
{
    class CompStmtTest
    {
        private IStmt stmt;

        public void Init()
        {
            stmt = new CompStmt(new AssignStmt("a", new ArithExpr(new ConstExpr(2), "*",
                new ConstExpr(3))), new PrintStmt(new ConstExpr(33)));
            Assert.AreEqual("( a = 2 * 3; print( 33 ) )", stmt.ToString());
        }
    }
}
