using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication6.src.repository;
using ConsoleApplication6.src.domain;
using ConsoleApplication6.src.com;
using System.Collections.Generic;

namespace ConsoleApplication6.src.controller
{
    interface IController
    {
        void Add(IStmt stm);
        void OneStepForAll(ArrayList<ProgState> prgl);
        void AllStep();
        List<ProgState> GetProg();
        void AddProg(ProgState prg);
        void SetToFile();
        void SetFileName(string file);
        void Serialize(string filename);
        void Deserialize(string filename);
        List<ProgState> RemoveCompletedPrg(List<ProgState> prgl);
        void PrintState(ProgState p);

    }
}
