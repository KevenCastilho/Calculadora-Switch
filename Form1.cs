using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Switch
{
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    {
        public String Visor { get; set; }
        public float numero { get; set; }
        public float tempRes { get; set; }
        public float resultado { get; set; }
        public int conta { get; set; }
        public Form1()
        {
            InitializeComponent();
            Visor = tbxVisor.Text;
            tempRes = 0;
            numero = 0;
            resultado = 0;
            conta = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            Visor = tbxVisor.Text + "0";
            numero = float.Parse(Visor);
            tbxVisor.Text = Visor;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Visor = tbxVisor.Text + "1";
            numero = float.Parse(Visor);
            tbxVisor.Text = Visor;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Visor = tbxVisor.Text + "2";
            numero = float.Parse(Visor);
            tbxVisor.Text = Visor;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Visor = tbxVisor.Text + "3";
            numero = float.Parse(Visor);
            tbxVisor.Text = Visor;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Visor = tbxVisor.Text + "4";
            numero = float.Parse(Visor);
            tbxVisor.Text = Visor;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Visor = tbxVisor.Text + "5";
            numero = float.Parse(Visor);
            tbxVisor.Text = Visor;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Visor = tbxVisor.Text + "6";
            numero = float.Parse(Visor);
            tbxVisor.Text = Visor;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Visor = tbxVisor.Text + "7";
            numero = float.Parse(Visor);
            tbxVisor.Text = Visor;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Visor = tbxVisor.Text + "8";
            numero = float.Parse(Visor);
            tbxVisor.Text = Visor;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Visor = tbxVisor.Text + "9";
            numero = float.Parse(Visor);
            tbxVisor.Text = Visor;
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            Visor = tbxVisor.Text + ",";
            numero = float.Parse(Visor);
            tbxVisor.Text = Visor;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            tbxVisor.Text = "";
        }

        private void btnVezes_Click(object sender, EventArgs e)
        {
            if(tempRes == 0)
            {
                tempRes = 1;
            }
            tempRes = tempRes * numero;
            tbxVisor.Text = "";
            conta = 5;
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            if (tempRes == 0)
            {
                tempRes = numero;
                tbxVisor.Text = "";
                conta = 4;
            } else
            {
                tempRes = tempRes / numero;
                tbxVisor.Text = "";
                conta = 4;
            }
        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            tempRes = tempRes + numero;
            tbxVisor.Text = "";
            conta = 3;
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            if(tempRes == 0)
            {
                tempRes = numero;
                tbxVisor.Text = "";
                conta = 2;
            } else {
                tempRes = tempRes - numero;
                tbxVisor.Text = "";
                conta = 2;
            }
        }

        private void btnPorcentagem_Click(object sender, EventArgs e)
        {
            if(tempRes == 0)
            {
                tempRes = numero;
                tbxVisor.Text = "";
                conta = 1;

            } else
            {
                tempRes = tempRes % numero;
                tbxVisor.Text = "";
                conta = 1;
            }
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            switch (conta)
            {
                case 1:
                    resultado = tempRes % numero;
                    break;
            
                case 2:
                    resultado = tempRes - numero;
                    break;
            
                case 3:
                    resultado = tempRes + numero;
                    break;
            
                case 4:
                    resultado = tempRes / numero;
                    break;
            
                case 5:
                    resultado = tempRes * numero;
                    break;

                default:
                    resultado = numero;
                    break;
            }
            Visor = resultado.ToString();
            tbxVisor.Text = Visor;
        }

        private void btnResetar_Click(object sender, EventArgs e)
        {
            tbxVisor.Text = "";
            numero = 0;
            tempRes = 0;
        }

        private void tbxVisor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
