using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6.src.com
{
    [Serializable]
    class ArrayList<El> : IList<El> 
    {
        private List<El> elems;

        public ArrayList()
        {
            elems = new List<El>();
        }

        /**
         * Returns the number of elements in the list
         * @return integer
         */
        public int Size()
        {
            return elems.Count;
        }

        /**
         * Resizes the list in case it gets full
         */
        //private void Resize()
        //{
        //    El[] temp = elems;
        //    capacity *= 2;
        //    elems = new El[capacity];
        //    for (int i = 0; i < temp.Length; i++)
        //    {
        //        elems[i] = temp[i];
        //    }
        //}

        /**
        * Adds an element in the back of the list
        * @param e - type El, element to be added
        */
        public void Add(El elem)
        {
            elems.Add(elem);
        }

        /**
        * Returns the element from the id
        * @param id - type integer
        * @return the element from id
        */
        public El Get(int id)
        {
            return elems.ElementAt(id);
        }

        /**
         * Returns true or false depending on whether the list is empty or not
         * @return true or false
         */
        public bool IsEmpty()
        {
            return elems.Count == 0;
        }


        /**
        * Returns and removes the element from the id
        * @param id - type integer
        * @return the element from id
        */
        public void Remove(int id)
        {
            elems.RemoveAt(id);
        }

        public override string ToString()
        {
            return "[ " + string.Join(", ", elems.ToArray())+ " ]";
        }

        public List<El> ToList()
        {
            List<El> prgl2 = new List<El>();
            int i = 0;
            for (i = 0; i < Size(); i++)
            {
                prgl2.Add(Get(i));
            }
            return prgl2;
        }
    }
}
