using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication6.src.domain;
using ConsoleApplication6.src.com;
using NUnit.Framework;

namespace ConsoleApplication6.src.tests
{
    class ConstExprTest
    {
        Expr e;
        ArrayDict<string, int> dict;
        ArrayDict<int, int> heap;

        public void Init()
        {
            e = new ConstExpr(33);
            dict = new ArrayDict<string, int>();
            dict.Add("g", 44);
            dict.Add("h", 22);

            Assert.AreEqual(33, e.Eval(dict, heap));
            Assert.AreEqual("33", e.ToString());
        }
    }
}
