using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSuma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TxtN1.Text = "";
            TxtN2.Text = "";
            TxtR.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double N1, N2, R;
            N1 = double.Parse(TxtN1.Text);
            N2 = double.Parse(TxtN2.Text);
            R = N1 + N2;
            TxtR.Text = R.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
