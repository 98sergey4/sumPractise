using System;
using System.Windows.Forms;

namespace WF_lab_4
{
    public partial class Form2 : Form
    {
        
        Form frm = new Form();
        public Form2()
        {
            InitializeComponent();
        }

        public void Form2_Load(object sender, EventArgs e)
        {
            
        }
        public void MD(int n, int A, int B)
        {
            textBox1.Text = Convert.ToString(n);
            textBox2.Text = Convert.ToString(A);
            textBox3.Text = Convert.ToString(B);
        }

        private void Form_cl(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }
    }
}
