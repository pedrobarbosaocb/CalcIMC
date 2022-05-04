using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        public static double CalcIMC(double Peso, double Altura)
        {
            return Peso / (Altura * Altura / 10000);
        }

        public static string VerificaClassificacao(double IMC)
        {
            if (IMC<16)
            {
                return "Magreza grave";
            } else if (IMC < 17)
            {
                return "Magreza moderada";
            } else if (IMC < 18.5)
            {
                return "Magreza leve";
            }
            else if (IMC < 25)
            {
                return "Saudável";
            }
            else if (IMC < 30)
            {
                return "Sobrepeso";
            } else
            {
                return "vish";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double imc = CalcIMC(double.Parse(txtPeso.Text), double.Parse(txtAltura.Text));

            lblResult.Text = imc.ToString("F2");
            lblClassificacao.Text = VerificaClassificacao(imc);

            panel1.Visible = true;
        }
    }
}
