using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication6.src.com;

namespace ConsoleApplication6.src.domain
{
    [Serializable]
    class VarExpr:Expr
    {
        private string id;

        /**
         * Constructor
         * @param idd - variable name
         */
        public VarExpr(string str)
        {
            this.id = str;
        }

        private string GetId
        {
            get
            {
                return id;
            }
        }

        public override string ToString()
        {
            return id;
        }

        public override int Eval(IDict<string, int> dict)
        {
            return dict.Get(id);
        }
    }
}
