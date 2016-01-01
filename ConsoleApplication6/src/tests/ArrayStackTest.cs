using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ConsoleApplication6.src.com;

namespace ConsoleApplication6.src.tests
{
    class ArrayStackTest
    {
        private ArrayStack<int> totest;
        public void Init()
        {
            totest = new ArrayStack<int>();
            totest.Push(1);
            totest.Push(2);

            //test Push
            totest.Push(3);
            Assert.AreEqual(3, totest.Size());

            //test Pop
            int w = totest.Pop();
            Assert.AreEqual(3, w);

            //test Size
            Assert.AreEqual(2, totest.Size());

            //test isEmpty
            Assert.AreEqual(false, totest.IsEmpty());

            //test ToString
            Assert.AreEqual("[ 1, 2 ]", totest.ToString());
        }

    }
}
