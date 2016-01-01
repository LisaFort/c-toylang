using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ConsoleApplication6.src.domain;
using ConsoleApplication6.src.com;

namespace ConsoleApplication6.src.tests
{
    class ArithExprTest
    {
        Expr e;
        ArrayDict<string, int> dict;
        ArrayDict<int, int> heap;
        public void Init()
        {
            e = new ArithExpr(new ConstExpr(3), "+", new ConstExpr(4));
            dict = new ArrayDict<string, int>();
            dict.Add("g", 44);
            dict.Add("h", 22);

            Assert.AreEqual(7, e.Eval(dict, heap));
            Assert.AreEqual("3 + 4", e.ToString());
        }


    }
}
