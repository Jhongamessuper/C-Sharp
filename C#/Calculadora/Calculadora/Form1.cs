using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Calculadora
{
    public partial class Form1 : Form
    {
        decimal calculo;
        bool Soma = false;
        bool Subtracao = false;
        bool Multiplicacao = false;
        bool Divisao = false;
        bool Visor = false;

        public object IblOperacao { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "3";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "1";
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            calculo = Convert.ToDecimal(txtVisor.Text);
            txtVisor.Text = "";
            Soma = false;
            Subtracao = true;
            Multiplicacao = false;
            Divisao = false;

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "0";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "9";
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            calculo = Convert.ToDecimal(txtVisor.Text);
            txtVisor.Text = "";
            Soma = false;
            Subtracao = false;
            Multiplicacao = false;
            Divisao = true;
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            calculo = Convert.ToDecimal(txtVisor.Text);
            txtVisor.Text = "";
            Soma = true;
            Subtracao = false;
            Multiplicacao = false;
            Divisao = false;

        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            calculo = Convert.ToDecimal(txtVisor.Text);
            txtVisor.Text = "";
            Soma = false;
            Subtracao = false;
            Multiplicacao = true;
            Divisao = false;

        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            txtVisor.Text += ",";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            Visor = true;
            if (Soma == true)
                txtVisor.Text = Convert.ToString(calculo + Convert.ToDecimal(txtVisor.Text));
            if (Subtracao == true)
                txtVisor.Text = Convert.ToString(calculo - Convert.ToDecimal(txtVisor.Text));
            if (Multiplicacao == true)
                txtVisor.Text = Convert.ToString(calculo * Convert.ToDecimal(txtVisor.Text));
            if (Divisao == true)
                txtVisor.Text = Convert.ToString(calculo / Convert.ToDecimal(txtVisor.Text));

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            try
            {
                string apagar = txtVisor.Text;
                apagar = apagar.Remove(apagar.Length - 1);
                txtVisor.Text = apagar;
            }
            catch (Exception)
            {
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtVisor.Text = "";
        }
    }
}
    

