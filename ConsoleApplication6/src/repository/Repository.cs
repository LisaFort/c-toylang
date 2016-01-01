using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication6.src.domain;
using ConsoleApplication6.src.com;
using System.IO;
using System.Collections.Generic;


namespace ConsoleApplication6.src.repository
{
    class Repository:IRepo
    {
        private List<ProgState> prgList;

        /**
         * Constructor
         * status - array of prog state
         */
        public Repository()
        {
            prgList = new List<ProgState>();
        }

        /**
         * Adds a Program state to the repository
         * @param state
         */
        public void AddState(ProgState prg)
        {
            prgList.Add(prg);
        }

        /**
         * Returns a program state from the repository list
         * @return
         */
        //public ProgState GetProg()
        //{
        //    if (prgList.IsEmpty())
        //    {
        //        return null;
        //    }
        //    else
        //    {
        //        ProgState prg = new ProgState(new ArrayList<int>(), new ArrayDict<string, int>(), new ArrayStack<IStmt>(),new ArrayDict<int,int>());
        //        prg = prgList.Get(prgList.Size() - 1);
        //        prgList.Remove(prgList.Size() - 1);
        //        return prg;
        //    }
        //}

        /**
         * Returns the number of elements from the program state
         * @return
         */
        public int Size()
        {
            return prgList.Count;
        }

        public void SerializeObj(System.Runtime.Serialization.IFormatter formatter, System.IO.Stream os)
        {
            List<ProgState> prg = GetProgList();
            formatter.Serialize(os, prg);
        }

        public void DeserializeObj(System.Runtime.Serialization.IFormatter formatter, System.IO.Stream ins) {
            List<ProgState> prgl = (List<ProgState>)formatter.Deserialize(ins);
            ArrayList<ProgState> arl = new ArrayList<ProgState>();
            for (int i = 0; i < prgl.Count; i++)
            {
                arl.Add(prgl.ElementAt(i));
            }

                SetPrgList(arl);
         }

        public void WriteToFile(string filename)
        {
            List<ProgState> prgl = GetProgList();
            for (int i = 0; i < prgl.Count; i++)
            {
                ProgState prg = prgl.ElementAt(i);
                StreamWriter filen = new StreamWriter(filename, true);
                filen.Write("Id: ");
                filen.Write(prg.GetId);
                filen.Write("\n");
                filen.Write("ExeStack \n");
                filen.Write(prg.GetExe.ToString());
                filen.Write("\n");
                filen.Write("SymTable \n");
                filen.Write(prg.GetSym.ToString());
                filen.Write("\n");
                filen.Write("Out \n");
                filen.Write(prg.GetOut.ToString());
                filen.Write("\n");
                filen.Close();
            }
        }

        public List<ProgState> GetProgList()
        {
            return prgList;
        }

        public void SetPrgList(ArrayList<ProgState> prgl)
        {
            List<ProgState> prgl2 = prgl.ToList();
            prgList = prgl2;
        }
    }
}
