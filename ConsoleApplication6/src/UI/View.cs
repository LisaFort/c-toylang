using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication6.src.repository;
using ConsoleApplication6.src.domain;
using ConsoleApplication6.src.com;
using ConsoleApplication6.src.controller;
using ConsoleApplication6.src.exceptions;

namespace ConsoleApplication6.src.UI
{
    class View
    {
        IController ctrl;

        private int GetInputInt()
        {
            int value;
            int.TryParse(Console.ReadLine(), out value);
            return value;
        }

        private string GetInputString()
        {
            string value = Console.ReadLine();
            return value;
        }

        public View(IController ctrl1)
        {
            this.ctrl = ctrl1;
        }

        private void Menu1()
        {
            Console.WriteLine("1. Input program");
            Console.WriteLine("2. One Step evaluation");
            Console.WriteLine("3. Complete evaluation");
            Console.WriteLine("4. Break");
            Console.WriteLine("5. Print stack ");
        }


        private void StmtMenu()
        {
            Console.WriteLine("What kind of statement? ");
            Console.WriteLine("1. Assign Statement \n" +
                    "2. Print Statement \n" +
                    "3. If Statement \n" +
                    "4. Compound Statement \n");
        }

        private void ExprMenu()
        {
            Console.WriteLine("1. Arithmetic Expression \n" +
                    "2. Constant Expression \n" +
                    "3. Variable Expression \n" +
                    "4. Read \n");
        }

        private void PrintMenu()
        {
            Console.WriteLine("1. Constant Expression \n" +
                     "2. Variable Expression \n " +
                     "3. Read" );
        }

        public void UiInput()
        {
            StmtMenu();
            IStmt stmt = AddStmt(GetInputString());
            Console.WriteLine("You've added to program: ");
            Console.WriteLine(stmt.ToString());
            ctrl.Add(stmt);
        }

        private IStmt AddStmt(String val)
        {
            switch (val)
            {
                case "1":
                    return AddAssignStmt();
                case "2":
                    return AddPrintStmt();
                case "3":
                    return AddIfStmt();
                case "4":
                    return AddCompStmt();
                default:
                    Console.WriteLine("Invalid option, try again");
                    StmtMenu();
                    return AddStmt(GetInputString());
            }
        }

        private IStmt AddAssignStmt()
        {
            Console.WriteLine("Give id");
            String id = GetInputString();
            ExprMenu();
            Expr expr = AddExpr(GetInputString());
            return new AssignStmt(id, expr);
        }

        private IStmt AddIfStmt()
        {
            ExprMenu();
            Expr exp = AddExpr(GetInputString());
            StmtMenu();
            IStmt stmt1 = AddStmt(GetInputString());
            StmtMenu();
            IStmt stmt2 = AddStmt(GetInputString());
            return new IfStmt(exp, stmt1, stmt2);
        }

        private IStmt AddCompStmt()
        {
            StmtMenu();
            IStmt stmt1 = AddStmt(GetInputString());
            StmtMenu();
            IStmt stmt2 = AddStmt(GetInputString());
            return new CompStmt(stmt1, stmt2);
        }

        private IStmt AddPrintStmt()
        {
            PrintMenu();
            Expr ex = PrintSwitch(GetInputString());
            return new PrintStmt(ex);
        }

        private Expr PrintSwitch(String val)
        {
            switch (val)
            {
                case "1":
                    return AddConstExpr();
                case "2":
                    return AddVarExpr();
                case "3":
                    return AddReadExpr();
                default:
                    Console.WriteLine("Invalid option, try again");
                    PrintMenu();
                    return PrintSwitch(GetInputString());
            }
        }

        private Expr AddConstExpr()
        {
            Console.WriteLine("Give number: ");
            return new ConstExpr(GetInputInt());
        }

        private Expr AddVarExpr()
        {
            Console.WriteLine("Give variable: ");
            return new VarExpr(GetInputString());
        }

        private Expr AddReadExpr()
        {
            return new read();
        }



        private Expr AddArithmeticExpr()
        {
            ExprMenu();
            String input = GetInputString();
            Expr exp1 = ArithSwitch(input);
            Console.WriteLine("Give Operation: + - * /");
            String ope = GetInputString();
            ExprMenu();
            input = GetInputString();
            Expr exp2 = ArithSwitch(input);
            return new ArithExpr(exp1, ope, exp2);
        }

        private Expr ArithSwitch(String value)
        {
            switch (value)
            {
                case "1":
                    return AddArithmeticExpr();
                case "2":
                    return AddConstExpr();
                case "3":
                    return AddVarExpr();
                case "4":
                    return AddReadExpr();
                default:
                    ExprMenu();
                    return AddArithmeticExpr();
            }
        }

        private Expr AddExpr(String val)
        {
            switch (val)
            {
                case "1":
                    return AddArithmeticExpr();
                case "2":
                    return AddConstExpr();
                case "3":
                    return AddVarExpr();
                case "4":
                    return AddReadExpr();
                default:
                    Console.WriteLine("Invalid option, try again");
                    ExprMenu();
                    return AddExpr(GetInputString());
            }
        }

        public void UioneStep()
        {
            try
            {
                ctrl.AllStep();
                ProgState prg = new ProgState(new ArrayList<int>(), new ArrayDict<string, int>(), new ArrayStack<IStmt>(), new ArrayDict<int, int>());
                //Console.WriteLine(prg.ToString());
                //prg = ctrl.GetProg();
                //Console.WriteLine(prg.ToString());
                ctrl.AddProg(prg);
            }
            catch (VariableNotFoundException e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            catch (UnsupportedOperationException e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            catch (EmptyStackException e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            catch (DivByZeroException e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            catch (EmptyDictException e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }

        public void UiAllSteps()
        {
            try
            {
                ctrl.AllStep();
                //ProgState prg = new ProgState(new ArrayList<int>(), new ArrayDict<string, int>(), new ArrayStack<IStmt>(), new ArrayDict<int, int>());
                //Console.WriteLine(prg.ToString());
                //prg = ctrl.GetProg();
                //if (prg == null)
                //{
                //    Console.WriteLine("There are no more programs in the repo ");

                //}
                //else
                //{
                //    Console.WriteLine(prg.ToString());
                //}
            }
            catch (VariableNotFoundException e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            catch (EmptyStackException e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }

        private void PrintStack()
        {
            List<ProgState> prgl = ctrl.GetProg();
            for (int i = 0; i < prgl.Count; i++)
            {
                ctrl.PrintState(prgl.ElementAt(i));
            }
            //ProgState prg = new ProgState(new ArrayList<int>(), new ArrayDict<string, int>(), new ArrayStack<IStmt>(), new ArrayDict<int,int>());
            //prg = ctrl.GetProg();
            //if (prg == null)
            //{
            //    Console.WriteLine("Nothing to print ");
            //    return;
            //}
            //Console.WriteLine(prg.ToString());
            //ctrl.AddProg(prg);
        }

        public void UiprintAll()
        {
            while (true)
            {
                Menu1();
                Console.WriteLine("Enter option: ");
                int input = GetInputInt();

                if (input == 1)
                {
                    UiInput();
                }
                if (input == 2)
                {/*
                    IStmt ex2 = new CompStmt(new AssignStmt("a", new ArithExpr(new ConstExpr(2), "+", new
                            ArithExpr(new ConstExpr(3), "*", new ConstExpr(5)))),
                            new CompStmt(new AssignStmt("b", new ArithExpr(new VarExpr("a"), "+", new
                                    ConstExpr(1))), new PrintStmt(new VarExpr("b"))));
                    ctrl.Add(ex2);*/
                    UioneStep();
                }
                if (input == 3)
                {/*
                    IStmt ex2 = new CompStmt(new AssignStmt("a", new ArithExpr(new ConstExpr(2), "+", new
                            ArithExpr(new ConstExpr(3), "*", new ConstExpr(5)))),
                            new CompStmt(new AssignStmt("b", new ArithExpr(new VarExpr("a"), "+", new
                                    ConstExpr(1))), new PrintStmt(new VarExpr("b"))));
                    ctrl.Add(ex2);*/
                    UiAllSteps();
                }
                if (input == 4)
                {
                    break;
                }
                if (input == 5)
                {
                    PrintStack();
                }
            }
        }
    }
}
