using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication6.src.domain;
using ConsoleApplication6.src.com;

namespace ConsoleApplication6.src.repository
{
    interface IRepo
    {
        void AddState(ProgState prg);
        //ProgState GetProg();
        int Size();
        void SerializeObj(System.Runtime.Serialization.IFormatter formatter, System.IO.Stream os);
        void DeserializeObj(System.Runtime.Serialization.IFormatter formatter, System.IO.Stream ins);
        void WriteToFile(string filename);
        List<ProgState> GetProgList();
        void SetPrgList(ArrayList<ProgState> prgl) ;


    }
}
