using ConsoleApplication6.src.exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6.src.com
{
    [Serializable]
    class ArrayDict<K, V> : IDict<K, V>
    {
        private Dictionary<K, V> dict;

        public ArrayDict() {
            dict = new Dictionary<K, V>();
        }

        /**
         * Adds a pair key-value to the dictionary
         * @param key - type K
         * @param val - type V
         */
        public void Add(K key, V val) {
            dict.Add(key, val);
        }

        /**
        * Resizes the dictionary in case it is filled
        */
        //private void Resize() {
        //    K[] tempkey = keys;
        //    V[] tempval = vals;
        //    MAXVAL *= 2;
        //    keys = new K[MAXVAL];
        //    vals = new V[MAXVAL];
        //    for ( int i = 0; i < keys.Length; i++) {
        //        keys[i] = tempkey[i];
        //        vals[i] = tempval[i];
        //    }
        //    keys = tempkey;
        //    vals = tempval;
        //}

        /**
        * Returns the number of elements in the dictionary
        * @return nrElems - int
        */
        public int Size() {
            return dict.Count;
        }

        /**
         *returns the value corresponding to the kay if the key given exists
         * @param key - type K
         * @return returns a value of type object
         */
        public V Get(K key) {
            if (dict.ContainsKey(key))
                return dict[key];
            else throw new VariableNotFoundException("In dict");
        }

        /**
         * Removes a key-value pair from the dictionary depending on the
         * @param key - type K, to find the pair to be deleted
         */
        public void Remove(K key) {
            dict.Remove(key);
        }

        /**
         * Returns true or false depending on whether the dictionary is empty
         * @return true or false
         */
        public bool IsEmpty()
        {
            return dict.Count == 0;
        }

        /**
         * modifies the value in the dictionary corresponding to the key given, if it exists
         * @param key - type object
         * @param new_val - type object
         */
        public void Modify(K key, V new_val)
        {
            dict[key] = new_val;
        }

        public override string ToString()
        {
            return "[ " + string.Join(", ", dict.Select(kv => kv.Key.ToString() + ":" + kv.Value.ToString()).ToArray()) + " ]";
        }

        public List<K> GetKeys()
        {
            return dict.Keys.ToList();
        }
    }
}
