using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6.src.com
{
    interface IList<El>
    {
        void Add(El element);
        El Get(int id);
        int Size();
        bool IsEmpty();
        void Remove(int id);

        List<El> ToList();
    }
}
