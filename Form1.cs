using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula7_WF_IMC
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            
            double p = double.Parse(txtPeso.Text);
            double a = double.Parse(txtAltura.Text);

            Calcular calculo = new Calcular();

            calculo.Altura = a;
            calculo.Peso = p;

            lblResultado.Text = calculo.IMC().ToString("F2");

            if (calculo.IMC() < 18.5)
            {
                lblIMC.Text = ("Peso abaixo do normal");
            }
            else if ((calculo.IMC() > 18.5) && (calculo.IMC() < 25))
            {
                lblIMC.Text = ("Peso normal");
            }
            else if ((calculo.IMC() > 25) && (calculo.IMC() < 30))
            {
                lblIMC.Text = ("Sobre o Peso");
            }
            else if ((calculo.IMC() > 30) && (calculo.IMC() < 35))
            {
                lblIMC.Text = ("Grau de Obesidade I");
            }
            else if ((calculo.IMC() > 35) && (calculo.IMC() < 40))
            {
                lblIMC.Text = ("Grau de Obesidade II");
            }
            else if (calculo.IMC() > 40)
            {
                lblIMC.Text = ("Obesidade Grau III");
            }
        }
    }
}
