using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication6.src.tests;
using ConsoleApplication6.src.repository;
using ConsoleApplication6.src.domain;
using ConsoleApplication6.src.controller;
using ConsoleApplication6.src.UI;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            testing();
            IRepo repo = new Repository();
            IController ctrl = new Controller(repo);
            //IStmt stmt = new CompStmt(new AssignStmt("v",new ConstExpr(10)), new CompStmt(
            //    new NewHeapStmt("v", new ConstExpr(20)), new CompStmt(new NewHeapStmt("a",
            //        new ConstExpr(20)), new CompStmt(new WriteHeapStmt("a",new ConstExpr(30)), new CompStmt(new PrintStmt(new VarExpr("a")),
            //            //new PrintStmt(new ReadHeapExpr("a")))))));
   //         IStmt stmt = new CompStmt(new AssignStmt("a", new ArithExpr(new ConstExpr(2), "*",
    //            new ConstExpr(3))), new PrintStmt(new ConstExpr(33)));
            //IStmt stmt = new CompStmt(new AssignStmt("a",new ConstExpr(1)), new CompStmt(new AssignStmt("v", new read()), new CompStmt(new SwitchStmt(new ConstExpr(1),
            //    new ConstExpr(0), new VarExpr("v"), new IfThenStmt(new LogicExpr(new VarExpr("v"),"&&", new VarExpr("a")),new AssignStmt("v",new ConstExpr(5)
            //    )), new AssignStmt("v", new LogicExpr(new VarExpr("v"),"||", new ConstExpr(1))), new AssignStmt("v", new ConstExpr(100))), new WhileStmt(new
            //    VarExpr("v"), new CompStmt(new AssignStmt("a",new ArithExpr(new VarExpr("a"),"+",new ConstExpr(1))), new AssignStmt("v", new ArithExpr(new
            //    VarExpr("v"),"-", new ConstExpr(1))))))));

    //        stmt = new AssignStmt("a", new ArithExpr(new ConstExpr(2), "/", new ConstExpr(0)));
     //       stmt = new AssignStmt("a", new ArithExpr(new ConstExpr(3), "i", new ConstExpr(2)));
            IStmt stmt = new CompStmt(new AssignStmt("v", new ConstExpr(10)), new CompStmt(new NewHeapStmt("a", new ConstExpr(22)),
                new CompStmt(new ForkStmt(new CompStmt(new WriteHeapStmt("a", new ConstExpr(30)), new CompStmt(new AssignStmt(
                    "v", new ConstExpr(32)), new CompStmt(new PrintStmt(new VarExpr("v")), new PrintStmt(new ReadHeapExpr("a"))))))
                    , new CompStmt(new PrintStmt(new VarExpr("v")), new PrintStmt(new ReadHeapExpr("a"))))));
            //ctrl.Add(stmt);
            //ctrl.SetFileName("WTFFF.txt");
            //ctrl.SetToFile();
            ctrl.Deserialize("D:/Projects/C#/console6/sert.txt");
            //ctrl.AllStep();
            //ctrl.SetFileName("D:/Projects/C#/console6/test.txt");
            //ctrl.SetToFile();
            //ctrl.AllStep(1);

            //Console.WriteLine("----------------");
            //ctrl.Serialize("D:/Projects/C#/console6/seri.txt");
            //ctrl.Deserialize("D:/Projects/C#/console6/seri.txt");
            //ProgState p2 = ctrl.GetProg();
            //Console.WriteLine(p2);
            //Console.WriteLine("----------------");
            View ui = new View(ctrl);
            ui.UiprintAll();
            }

        static void testing()
        {
            ArrayListTest arr = new ArrayListTest();
            arr.Init();
            ArrayDictTest dic = new ArrayDictTest();
            dic.Init();
            ArrayStackTest stk = new ArrayStackTest();
            stk.Init();
            CompStmtTest cstm = new CompStmtTest();
            cstm.Init();
            AssignStmtTest astm = new AssignStmtTest();
            astm.Init();
            PrintStmtTest pstm = new PrintStmtTest();
            pstm.Init();
            IfStmtTest istm = new IfStmtTest();
            istm.Init();
            ArithExprTest aexp = new ArithExprTest();
            aexp.Init();
            ConstExprTest cexp = new ConstExprTest();
            cexp.Init();
            VarExprTest vexp = new VarExprTest();
            vexp.Init();
            ProgStateTest prg = new ProgStateTest();
            prg.Init();
            RepositoryTest rep = new RepositoryTest();
            rep.Init();
            ControllerTest ctr = new ControllerTest();
            ctr.Init();
        }
    }
}
