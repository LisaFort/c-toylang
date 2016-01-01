using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication6.src.com;
using System.Diagnostics;
using NUnit.Framework;

namespace ConsoleApplication6.src.tests
{
    class ArrayListTest
    {
        private ArrayList<string> totest;
        
        public void Init() {
            totest = new ArrayList<string>();
            totest.Add("a");
            totest.Add("b");

            //test Add
            totest.Add("c");
            Assert.AreEqual("c", totest.Get(2));

            //test Get
            Assert.AreEqual("b", totest.Get(1));

            //testSize
            Assert.AreEqual(3, totest.Size());

            //test IsEmpty
            Assert.AreEqual(false, totest.IsEmpty());

            //test Remove
            totest.Add("aa");
            String wtf = (String)totest.Get(0);
            Assert.AreEqual("a", wtf);
            Assert.AreEqual(false, totest.IsEmpty());

        }

    }
}
