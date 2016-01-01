using ConsoleApplication6.src.com;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6.src.domain
{
    [Serializable]
    class read:Expr
    {
        public read()
        {
        }
        private int GetInputInt()
        {
            int value;
            int.TryParse(Console.ReadLine(), out value);
            return value;

        }

        public override int Eval(com.IDict<string, int> dict, IDict<int,int> heap)
        {
            Console.Write("Give int: ");
            int v = GetInputInt();
            return v;
        }

        public override string ToString()
        {
            return "read()";
        }
    }
}
