using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication6.src.com;
using ConsoleApplication6.src.exceptions;

namespace ConsoleApplication6.src.domain
{
    [Serializable]
    class ProgState
    {
        private IList<int> output;
        private IDict<string, int> symTable;
        private IStack<IStmt> exeStack;
        private IDict<int, int> heap;
        private int id;
        private Random rnd = new Random();

        /**
         * Constructor
         * @param stk - execution stack
         * @param symtbl - symbol table
         * @param ot - output list
         */
        public ProgState(IList<int> o, IDict<string, int> s, IStack<IStmt> e, IDict<int, int> hp)
        {
            this.output = o;
            this.symTable = s;
            this.exeStack = e;
            this.heap = hp;
            this.id = rnd.Next(1, 1000);
        }

        public int GetId
        {
            get
            {
                return id;
            }
        }
        public IDict<int, int> GetHeap
        {
            get
            {
                return heap;
            }
        }

        public IList<int> GetOut
        {
            get
            {
                return output;
            }
        }

        public IDict<string, int> GetSym {
            get{
                return symTable;
            }
        }

        public IStack<IStmt> GetExe {
            get{ 
                return exeStack;
            }
        }

        public String ToStrOut() {
            return output.ToString();
        }

        public String ToStrSym()
        {
            return symTable.ToString();
        }

        public String ToStrExe()
        {
            return exeStack.ToString();
        }

        public String ToStrHeap()
        {
            return heap.ToString();
        }

        public override String ToString()
        {
            String stat = "Id: " + id + "\n" + "Stack: " + ToStrExe() + "\n" + "Output: " + ToStrOut() + "\n" + " SymTable: " + ToStrSym() + "\n" + "Heap: " + ToStrHeap();
            return stat;
        }

        public bool IsNotCompleted()
        {
            return !exeStack.IsEmpty();
        }


        public ProgState OneStep()
        {
            if (exeStack.IsEmpty())
            {
                throw new MyStmtException("Exception in onestep progstate \n");
            }
            IStmt stm = exeStack.Pop();
            return stm.execute(this);
        }
    }
}
