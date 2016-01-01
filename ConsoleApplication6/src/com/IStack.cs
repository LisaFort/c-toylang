using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6.src.com
{
    interface IStack<El>
    {
        bool IsEmpty();
        void Push(El e);
        int Size();
        El Pop();


    }
}
