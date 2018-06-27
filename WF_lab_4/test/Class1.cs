using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WF_lab_4;
using NUnit.Framework;

namespace test
{
    public class Class1
    {
        MyClass clas = new MyClass();
        [Test]
        public void TestMethod1()//Тест метода Genr
        {
            int size = 5;
            int a = 100;
            int b = 200;
            clas.Genr(size, a, b);
            Assert.That(size, Is.EqualTo(clas.mass.Length));
        }
        [Test]
        public void TestMethod11()//Тест метода Genr
        {
            int size = 5;
            int a = 100;
            int b = 100;
            clas.Genr(size, a, b);
            Assert.That(a, Is.EqualTo(clas.mass[0][0]));
        }
        
        [Test]
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
            Assert.That(clas.el, Is.EqualTo(2));
        }
        [Test]
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
            Assert.That(clas.el, Is.EqualTo(3));
        }
        [Test]
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
            Assert.That(clas.mass[0][0], Is.EqualTo(1));
        }
        [Test]
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
            Assert.That(clas.mass[0][1],Is.EqualTo(2));
        }
        [Test]
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
            Assert.That(clas.mass[0][1], Is.EqualTo(-2));
        }
        [Test]
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
            Assert.That(clas.mass[1][1], Is.EqualTo(-16));
        }
    }
}