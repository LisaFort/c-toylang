using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6.src.com
{
    [Serializable]
    class ArrayStack<El> : IStack<El>
    {
        private Stack<El> elems;

        public ArrayStack()
        {
            elems = new Stack<El>();
        }

        /**
        * adds an element to the stack
        * @param e - type El
        */
        public void Push(El e)
        {
            elems.Push(e);
        }

        /**
        * Resizes the stack in case it is full
        */
        //private void Resize()
        //{
        //    El[] temp = elems;
        //    MAXVAL *= 2;
        //    elems = new El[MAXVAL];
        //    for (int i = 0; i < temp.Length; i++)
        //    {
        //        elems[i] = temp[i];
        //    }
        //}

        /**
         * returns an element from the front of the stack
         * @return element
         */
        public El Pop()
        {
            return elems.Pop();
        }

        public int Size()
        {
            return elems.Count;
        }

        /**
         * Returns true or false depending on whther the stack is empty
         * @return true or false
         */
        public bool IsEmpty()
        {
            return elems.Count == 0;
        }

        public override string ToString()
        {
            return "[ " + string.Join(", ", elems.ToArray().Reverse()) + " ]";
        }
    }
}
