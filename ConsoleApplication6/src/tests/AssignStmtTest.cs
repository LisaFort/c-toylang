using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication6.src.domain;
using NUnit.Framework;

namespace ConsoleApplication6.src.tests
{
    class AssignStmtTest
    {
        private IStmt stmt;

        public void Init()
        {
            stmt = new AssignStmt("a", new ArithExpr(new ConstExpr(2), "*", new ConstExpr(3)));
            Assert.AreEqual("a = 2 * 3", stmt.ToString());
        }
    }
}
