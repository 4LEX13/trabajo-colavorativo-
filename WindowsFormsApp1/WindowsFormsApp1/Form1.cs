using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Dominio;
using WindowsFormsApp1.Negocio;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            clsLogin clsl = new clsLogin();
            login.User = textUser.Text;
            login.Pass = textContra.Text;
            Boolean ok = clsl.entrar(login);
            if (ok==true)
            {
                MessageBox.Show("welcome");
            }
            else
            {
                MessageBox.Show("stop");
            }
            {

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textContra_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
