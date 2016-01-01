using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ConsoleApplication6.src.domain;

namespace ConsoleApplication6.src.tests
{
    class IfStmtTest
    {
        private IStmt stmt;

        public void Init()
        {
            stmt = new IfStmt(new VarExpr("a"), new AssignStmt("v", new ConstExpr(2)), new
                 AssignStmt("v", new ConstExpr(3)));
            Assert.AreEqual("If a then v = 2 else v = 3", stmt.ToString());
        }
    }
}
