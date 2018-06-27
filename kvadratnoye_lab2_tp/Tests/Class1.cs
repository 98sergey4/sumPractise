using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kvadratnoye_lab2_tp;
using NUnit.Framework;

namespace Tests
{
    public class Class1
    {
        [Test]
        public void Test1()
        {
            EventArgs e = new EventArgs();
            Form1 test = new Form1();
            test.radio_button_obrabotchik.Checked = true;
            test.textBox1.Text = "-4";
            test.textBox2.Text = "5";
            test.textBox3.Text = "-1";
            double expected = 1.000;
            test.result1 = 0;
            test.Button_result(this, e);
            Assert.That(test.result2, Is.EqualTo(expected));
            expected = 0.25;
            Assert.That(test.result1, Is.EqualTo(expected));
        }
        [Test]
        public void Test11()
        {
            EventArgs e = new EventArgs();
            Form1 test = new Form1();
            test.radio_button_obrabotchik.Checked = true;
            test.textBox1.Text = "4.21";
            test.textBox2.Text = "10";
            test.textBox3.Text = "-5.075";
            double expected = -2.805;
            test.result1 = 0;
            test.Button_result(this, e);
            test.result1 = Math.Round(test.result1, 3);
            test.result2 = Math.Round(test.result2, 3);
            Assert.That(test.result2, Is.EqualTo(expected));
            expected = 0.430;
            Assert.That(test.result1, Is.EqualTo(expected));
        }
        [Test]
        public void Test111()
        {
            EventArgs e = new EventArgs();
            Form1 test = new Form1();
            test.radio_button_obrabotchik.Checked = true;
            test.textBox1.Text = "7";
            test.textBox2.Text = "-20.2";
            test.textBox3.Text = "-12";
            double expected = -0.506;
            test.result1 = 0;
            test.Button_result(this, e);
            test.result1 = Math.Round(test.result1, 3);
            test.result2 = Math.Round(test.result2, 3);
            Assert.That(test.result2, Is.EqualTo(expected));
            expected = 3.391;
            Assert.That(test.result1, Is.EqualTo(expected));
        }
        [Test]
        public void Test2()
        {
            EventArgs e = new EventArgs();
            Form1 test = new Form1();
            test.radio_button_obrabotchik.Checked = true;
            test.textBox1.Text = "1";
            test.textBox2.Text = "-4";
            test.textBox3.Text = "4";
            double expected = 2.000;
            test.result1 = 0;
            test.Button_result(this, e);
            Assert.That(test.result2, Is.EqualTo(expected));
            expected = 2.000;
            Assert.That(test.result1, Is.EqualTo(expected));
        }
        [Test]
        public void Test22()
        {
            EventArgs e = new EventArgs();
            Form1 test = new Form1();
            test.radio_button_obrabotchik.Checked = true;
            test.textBox1.Text = "1";
            test.textBox2.Text = "-6";
            test.textBox3.Text = "9";
            double expected = 3.000;
            test.result1 = 0;
            test.Button_result(this, e);
            Assert.That(test.result2, Is.EqualTo(expected));
            expected = 3.000;
            Assert.That(test.result1, Is.EqualTo(expected));
        }
        [Test]
        public void Test222()
        {
            EventArgs e = new EventArgs();
            Form1 test = new Form1();
            test.radio_button_obrabotchik.Checked = true;
            test.textBox1.Text = "1";
            test.textBox2.Text = "12";
            test.textBox3.Text = "36";
            double expected = -6.000;
            test.result1 = 0;
            test.Button_result(this, e);
            Assert.That(test.result2, Is.EqualTo(expected));
            expected = -6.000;
            Assert.That(test.result1, Is.EqualTo(expected));
        }
        [Test]
        public void Test3()
        {
            EventArgs e = new EventArgs();
            Form1 test = new Form1();
            test.radio_button_obrabotchik.Checked = true;
            test.textBox1.Text = "24";
            test.textBox2.Text = "1";
            test.textBox3.Text = "36";
            double expected = 0;
            test.result1 = 0;
            test.Button_result(this, e);
            Assert.That(test.result2, Is.EqualTo(expected));
            expected = 0;
            Assert.That(test.result1, Is.EqualTo(expected));
        }
        [Test]
        public void Test33()
        {
            EventArgs e = new EventArgs();
            Form1 test = new Form1();
            test.radio_button_obrabotchik.Checked = true;
            test.textBox1.Text = "42.214";
            test.textBox2.Text = "1.5";
            test.textBox3.Text = "36";
            double expected = 0;
            test.result1 = 0;
            test.Button_result(this, e);
            Assert.That(test.result2, Is.EqualTo(expected));
            expected = 0;
            Assert.That(test.result1, Is.EqualTo(expected));
        }
        [Test]
        public void Test4()
        {
            EventArgs e = new EventArgs();
            Form1 test = new Form1();
            test.radio_button_obrabotchik.Checked = true;
            test.textBox1.Text = "sa";
            test.textBox2.Text = "ew";
            test.textBox3.Text = "qw";
            double expected = 0;
            test.result1 = 0;
            test.Button_result(this, e);
            Assert.That(test.result2, Is.EqualTo(expected));
            expected = 0;
            Assert.That(test.result1, Is.EqualTo(expected));
        }
        [Test]
        public void Test44()
        {
            EventArgs e = new EventArgs();
            Form1 test = new Form1();
            test.radio_button_obrabotchik.Checked = true;
            test.textBox1.Text = "23";
            test.textBox2.Text = "-";
            test.textBox3.Text = "4";
            double expected = 0;
            test.result1 = 0;
            test.Button_result(this, e);
            Assert.That(test.result2, Is.EqualTo(expected));
            expected = 0;
            Assert.That(test.result1, Is.EqualTo(expected));
        }
        [Test]
        public void Test444()
        {
            EventArgs e = new EventArgs();
            Form1 test = new Form1();
            test.radio_button_obrabotchik.Checked = true;
            test.textBox1.Text = "+4";
            test.textBox2.Text = "-,";
            test.textBox3.Text = "4";
            double expected = 0;
            test.result1 = 0;
            test.Button_result(this, e);
            Assert.That(test.result2, Is.EqualTo(expected));
            expected = 0;
            Assert.That(test.result1, Is.EqualTo(expected));
        }
    }
}
