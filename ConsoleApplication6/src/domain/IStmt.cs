using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6.src.domain
{
    interface IStmt
    {
        string ToString();
        ProgState execute(ProgState prg);
    }
}
