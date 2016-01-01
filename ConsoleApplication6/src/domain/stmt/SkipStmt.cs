using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6.src.domain
{
    [Serializable]
    class SkipStmt:IStmt
    {
        public override String ToString()
        {
            return "SkipStatement";
        }
    }
}
