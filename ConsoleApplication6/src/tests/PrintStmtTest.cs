using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication6.src.domain;
using NUnit.Framework;

namespace ConsoleApplication6.src.tests
{
    class PrintStmtTest
    {
        private IStmt stmt;

        public void Init()
        {
            stmt = new PrintStmt(new ArithExpr(new ConstExpr(3), "+", new ConstExpr(4)));
            Assert.AreEqual("print( 3 + 4 )", stmt.ToString());
        }

    }
}
