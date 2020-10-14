using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using calculadoraDePromedios.Dominio;
using calculadoraDePromedios.Logica;

namespace calculadoraDePromedios
{
    public partial class Form1 : Form
    
    {
        clsLogica Clscal = new clsLogica();
        clsPrincipal ClsAtributos = new clsPrincipal();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
        //procesos
        private void button1_Click(object sender, EventArgs e)
        {
            Double Lab1 = Convert.ToDouble(txtLab1.Text);

            Double Parc1 = Convert.ToDouble(txtParc1.Text);


            double Resul1 = Clscal.Periodo3(Lab1, Parc1);

            txtResul1.Text = Resul1.ToString();

            Double Lab2 = Convert.ToDouble(txtLab2.Text);

            Double Parc2 = Convert.ToDouble(txtParc2.Text);


            double Resul2 = Clscal.Periodo3(Lab2, Parc2);

            txtResul2.Text = Resul2.ToString();

            Double Lab3 = Convert.ToDouble(txtLab3.Text);

            Double Parc3 = Convert.ToDouble(txtParc3.Text);


            double Resul3 = Clscal.Periodo3(Lab3, Parc3);

            txtResul3.Text = Resul3.ToString();

            double ResulF = Clscal.ResultadoFinal(Resul1, Resul2, Resul3);
            txtFinal.Text = ResulF.ToString();

 
                if (ResulF >= 0 && ResulF < 6)
                {
                MessageBox.Show("El alumno se encuentra:"+" Reprobado");

  
                }
                else
                {
                    MessageBox.Show("El alumno se encuentra:" + " Aprobado");
                }


            }

        private void txtLab2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
