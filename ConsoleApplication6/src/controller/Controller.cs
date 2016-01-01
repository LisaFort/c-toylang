using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication6.src.repository;
using ConsoleApplication6.src.domain;
using ConsoleApplication6.src.com;
using ConsoleApplication6.src.exceptions;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ConsoleApplication6.src.controller
{
    class Controller:IController
    {
        private IRepo repo;
        private bool toFile;
        private string filename;

        /**
         * Constructor
         * @param rep - repository
         */
        public Controller(IRepo rep)
        {
            this.repo = rep;
            toFile = false;
        }

        public void SetToFile()
        {
            toFile = true;
        }

        public void SetFileName(string file)
        {
            filename = file;
        }

        public void Serialize(string filename)
        {
            using (Stream stream = File.Create(filename))
            {
                var bform = new BinaryFormatter();
                repo.SerializeObj(bform, stream);
            }
        }

        public void Deserialize(string filename)
        {
            using (Stream stream = File.Open(filename, FileMode.Open))
            {
                var bform = new BinaryFormatter();
                repo.DeserializeObj(bform, stream);
            }
        }
        /**
        * Adds a statemtn to the repository
        * @param stmt - type IStmt, statement to be added
        */
        public void Add(IStmt stmt)
        {
            ProgState prg = new ProgState(new ArrayList<int>(), new ArrayDict<string, int>(), new ArrayStack<IStmt>(), new ArrayDict<int, int>());
            prg.GetExe.Push(stmt);
            repo.AddState(prg);
        }

        /**
         * Adds a program state to the repository
         * @param prg - type ProgState, progState to be added
         */
        public void AddPrg(ProgState prg)
        {
            repo.AddState(prg);
        }

        /**
         * Runs the program state only one step
         * @param prg - type ProgState,
         * @throws VarNotFound
         * @throws EmptyStack
         */
        public void OneStepForAll(ArrayList<ProgState> prgl)
        {
            List<ProgState> prgl2 = prgl.ToList();
            foreach (ProgState p in prgl2) PrintState(p);
            List<Task<ProgState>> taskList =(from prg in prgl2
                                                select Task<ProgState>.Factory.StartNew(() =>prg.OneStep())).ToList();
            List<ProgState> newPrgList =(from tsk in taskList
                                          where tsk.Result != null
                                          select tsk.Result).ToList();
            int i = 0;
            while (i < newPrgList.Count)
            {
                ProgState p = (ProgState)newPrgList.ElementAt(i);
                prgl2.Add(p);
                i++;
            }
            ArrayList<ProgState> wtf = new ArrayList<ProgState>();
            for (i = 0; i < prgl2.Count; i++)
            {
                wtf.Add(prgl2.ElementAt(i));
            }
            foreach (ProgState p in prgl2) PrintState(p);
            repo.SetPrgList(wtf);

        }

        public void PrintState(ProgState p)
        {
            if (toFile) {
            try {
                    repo.AddState(p);
                    repo.WriteToFile(filename);
                } catch (IOException e) {
                Console.WriteLine("Exception in printstate ctrl");
            }
        }else {
            Console.WriteLine(p.ToString());
        }
        }

        /**
         * takes a program state from the repository and runs it until the stack is empty
         * if flag is 1, it only runs one step
         * @param flag - type integer
         * @throws VarNotFound
         */
        public void AllStep()
        {
            while (true)
            {
                //remove the completed programs
                List<ProgState> prgList = RemoveCompletedPrg(repo.GetProgList());
                if (prgList.Count == 0)
                {
                    return;
                }
                else
                {
                    ArrayList<ProgState> prgl2 = new ArrayList<ProgState>();
                    int i = 0;
                    for (i = 0; i < prgList.Count; i++)
                    {
                        prgl2.Add(prgList.ElementAt(i));
                    }
                    OneStepForAll(prgl2);
                }
            }
        }

        /**
        * Returns a program state from the repository
        * @return
        */
        public List<ProgState> GetProg()
        {
            return repo.GetProgList();
        }

        public void AddProg(ProgState prg)
        {
            repo.AddState(prg);
        }

        public List<ProgState> RemoveCompletedPrg(List<ProgState> prgl)
        {
            return prgl.Where(p => p.IsNotCompleted()).ToList();
        }
    }
}
