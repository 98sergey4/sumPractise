using System;
using System.Windows.Forms;

namespace WF_lab_4
{
    public partial class Form1 : Form
    {
        Form3 frm3 = new Form3();
        MyClass clas = new MyClass();
        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button_run(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                clas.Genr((int)numericUpDown1.Value, (int)numericUpDown2.Value, (int)numericUpDown3.Value);
                radioButton1.Enabled = true;
                radioButton2.Enabled = true;
                radioButton3.Enabled = true;
            }
            else if (radioButton1.Checked == true)
            {
                clas.FirstMeth((int)numericUpDown2.Value, (int)numericUpDown3.Value);
            }
            else if (radioButton2.Checked == true)
            {
                clas.SecondMeth((int)numericUpDown2.Value, (int)numericUpDown3.Value);
            }
            else if (radioButton3.Checked == true)
            {
                if (numericUpDown4.Value > 0)
                {
                    clas.ThrithMeth((int)numericUpDown2.Value, (int)numericUpDown3.Value, (int)numericUpDown4.Value);
                }
                else
                {
                    MessageBox.Show("Укажите t!");
                    return;
                }
            }
        }

        private void button_info(object sender, EventArgs e)
        {
            frm3.Show();
        }

        private void Button_save(object sender, EventArgs e)
        {
            clas.SaveMass();
        }

        private void Button_Load(object sender, EventArgs e)
        {
            clas.Load();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
