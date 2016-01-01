using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ConsoleApplication6.src.controller;
using ConsoleApplication6.src.com;
using ConsoleApplication6.src.domain;
using ConsoleApplication6.src.repository;

namespace ConsoleApplication6.src.tests
{
    class ControllerTest
    {
        private IController ctrl;

        public void Init()
        {
            //ctrl = new Controller(new Repository());
            //IStmt stm = new CompStmt(new AssignStmt("a", new ArithExpr(new ConstExpr(2), "*",
            //        new ConstExpr(3))), new PrintStmt(new ConstExpr(33)));
            //ctrl.Add(stm);
            //ProgState prg = new ProgState(new ArrayList<int>(), new ArrayDict<string, int>(), new ArrayStack<IStmt>(), new ArrayDict<int,int>());
            //prg = ctrl.GetProg();
            //Assert.AreEqual("[ ( a = 2 * 3; print( 33 ) ) ]", prg.ToStrExe());

            //stm = new AssignStmt("a", new ArithExpr(new ConstExpr(2), "+",
            //    new ConstExpr(3)));
            //ctrl.Add(stm);
            //prg = ctrl.GetProg();
            //ctrl.OneStep(prg);
            //Assert.AreEqual("[ a:5 ]", prg.ToStrSym());

            //stm = new CompStmt(new AssignStmt("a", new ArithExpr(new ConstExpr(2), "*",
            //        new ConstExpr(3))), new PrintStmt(new ConstExpr(33)));
            //ctrl.Add(stm);
            //ctrl.AllStep(1);
            //prg = ctrl.GetProg();
            //Assert.AreEqual("[ print( 33 ), a = 2 * 3 ]", prg.ToStrExe());

            //stm = new PrintStmt(new ArithExpr(new ConstExpr(3), "+", new ConstExpr(4)));
            //ctrl.Add(stm);
            //prg = ctrl.GetProg();
            //ctrl.OneStep(prg);
            //Assert.AreEqual("[ 7 ]", prg.ToStrOut());

            //stm = new IfStmt(new ConstExpr(22), new AssignStmt("v", new ConstExpr(2)), new
            //        AssignStmt("v", new ConstExpr(3)));
            //ctrl.Add(stm);
            //prg = ctrl.GetProg();
            //ctrl.OneStep(prg);
            //Assert.AreEqual("[ v = 2 ]", prg.ToStrExe());

            //stm = new CompStmt(new AssignStmt("a", new ArithExpr(new ConstExpr(2), "+",
            //    new ConstExpr(3))), new CompStmt(new PrintStmt(new VarExpr("a")),
            //    new AssignStmt("a", new ArithExpr(new VarExpr(("a")), "+", new ConstExpr(3)))));
            //ctrl.Add(stm);
            //ctrl.AllStep(0);
            //prg = ctrl.GetProg();
            //Assert.AreEqual("[ 5 ]", prg.ToStrOut());

        }
    }
}
