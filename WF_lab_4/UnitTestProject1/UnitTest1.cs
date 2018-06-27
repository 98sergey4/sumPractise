using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WF_lab_4;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        MyClass clas = new MyClass();

        [TestMethod]
        public void TestMethod1()//Тест метода Genr
        {
            int size = 5;
            int a = 100;
            int b = 200;
            clas.Genr(size, a, b);
            Assert.AreEqual(size, clas.mass.Length);
        }
        [TestMethod]
        public void TestMethod11()//Тест метода Genr
        {
            int size = 5;
            int a = 100;
            int b = 100;
            clas.Genr(size, a, b);
            Assert.AreEqual(a, clas.mass[0][0]);
        }
        [TestMethod]//Тест метода Load
        public void TestMethod2()
        {
            clas.Load();
            string mat = "Arr";
            int[][] mas = new int[2][];
            mas[0] = new int[2];
            mas[1] = new int[2];
            mas[0][0] = 1;
            Assert.AreEqual(mas[0][0], clas.mass[0][0]);
        }
        [TestMethod]
        public void TestMethod22()//Тест метода Load
        {
            clas.Load();
            string mat = "Arr";
            int[][] myMass = new int[2][];
            myMass[0] = new int[2];
            myMass[1] = new int[2];
            myMass[0][0] = 1;
            myMass[0][1] = 2;
            Assert.AreEqual(myMass[0][1], clas.mass[0][1]);
        }
        [TestMethod]
        public void TestMethod3()//Тест метода FirstMeth
        {
            clas.mass = new int[2][];
            clas.mass[0] = new int[2];
            clas.mass[1] = new int[2];
            clas.mass[0][0] = 3;
            clas.mass[0][1] = 2;
            clas.mass[1][0] = 5;
            clas.mass[1][1] = 1;
            int a = 100;
            int b = 100;
            clas.N = 2;
            clas.FirstMeth(a, b);
            Assert.AreEqual(clas.el, 2);
        }
        [TestMethod]
        public void TestMethod33()//Тест метода FirstMeth
        {
            clas.mass = new int[2][];
            clas.mass[0] = new int[2];
            clas.mass[1] = new int[2];
            clas.mass[0][0] = 5;
            clas.mass[0][1] = 4;
            clas.mass[1][0] = 3;
            clas.mass[1][1] = 4;
            int a = 100;
            int b = 100;
            clas.N = 2;
            clas.FirstMeth(a, b);
            Assert.AreEqual(clas.el , 3);
        }
        [TestMethod]
        public void TestMethod4()//Тест метода SecondMeth
        {
            clas.mass = new int[2][];
            clas.mass[0] = new int[2];
            clas.mass[1] = new int[2];
            clas.mass[0][0] = 2;
            clas.mass[0][1] = 1;
            clas.mass[1][0] = 4;
            clas.mass[1][1] = 3;
            int a = 100;
            int b = 100;
            clas.N = 2;
            clas.SecondMeth(a, b);
            Assert.AreEqual(clas.mass[0][0], 1);
        }
        [TestMethod]
        public void TestMethod44()//Тест метода SecondMeth
        {
            clas.mass = new int[2][];
            clas.mass[0] = new int[2];
            clas.mass[1] = new int[2];
            clas.mass[0][0] = 1;
            clas.mass[0][1] = 2;
            clas.mass[1][0] = 3;
            clas.mass[1][1] = 4;
            int a = 100;
            int b = 100;
            clas.N = 2;
            clas.SecondMeth(a, b);
            Assert.AreEqual(clas.mass[0][1], 2);
        }
        [TestMethod]
        public void TestMethod5()//Тест метода ThridMeth
        {
            clas.mass = new int[2][];
            clas.mass[0] = new int[2];
            clas.mass[1] = new int[2];
            clas.mass[0][0] = 1;
            clas.mass[0][1] = 2;
            clas.mass[1][0] = 3;
            clas.mass[1][1] = 4;
            int a = 100;
            int b = 100;
            int t = 1;
            clas.N = 2;
            clas.ThrithMeth(a, b, t);
            Assert.AreEqual(clas.mass[0][1], -2);
        }
        [TestMethod]
        public void TestMethod55()//Тест метода ThridMeth
        {
            clas.mass = new int[2][];
            clas.mass[0] = new int[2];
            clas.mass[1] = new int[2];
            clas.mass[0][0] = 4;
            clas.mass[0][1] = 5;
            clas.mass[1][0] = 7;
            clas.mass[1][1] = 8;
            int a = 100;
            int b = 100;
            int t = 2;
            clas.N = 2;
            clas.ThrithMeth(a, b, t);
            Assert.AreEqual(clas.mass[1][1], -16);
        }
    }
}
