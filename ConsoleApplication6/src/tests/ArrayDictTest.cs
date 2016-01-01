using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ConsoleApplication6.src.com;

namespace ConsoleApplication6.src.tests
{
    class ArrayDictTest
    {
        private ArrayDict<string, int> totest;

        public void Init()
        {
            totest = new ArrayDict<string, int>();
            totest.Add("a", 1);
            totest.Add("b", 2);

            //test Add
            totest.Add("c", 3);
            Assert.AreEqual(2, totest.Get("b"));

            //test Get
            Assert.AreEqual(1, totest.Get("a"));

            //test Size
            Assert.AreEqual(3, totest.Size());

            //test IsEmpty
            Assert.AreEqual(false, totest.IsEmpty());

            //test Remove
            Assert.AreEqual(3, totest.Get("c"));
            totest.Remove("b");
            Assert.AreEqual(2, totest.Size());
            Assert.AreEqual(3, totest.Get("c"));

            //test Modify
            totest.Modify("a", 33);
            Assert.AreEqual(33, totest.Get("a"));

            //test ToString
            Assert.AreEqual("[ a:33, c:3 ]", totest.ToString());
        }
    }
}
