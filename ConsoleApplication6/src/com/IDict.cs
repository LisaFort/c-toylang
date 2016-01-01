using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6.src.com
{
    interface IDict <K, V>
    {
        void Add(K key, V value);
        void Modify(K key, V new_value);
        bool IsEmpty();
        int Size();
        void Remove(K key);
        V Get(K key);
        List<K> GetKeys();
    }
}
