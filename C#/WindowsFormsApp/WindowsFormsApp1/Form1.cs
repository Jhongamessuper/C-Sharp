using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConcatenacao_Click(object sender, EventArgs e)
        {
            string nome;
            string sobrenome;
            string nomeSobrenome;
            nome = txtnome.Text;
            sobrenome = txtsobrenome.Text;
            nomeSobrenome = nome + " " + sobrenome;
            txtNomeSobrenome.Text = nomeSobrenome;
        }


        private void btn1_Click(object sender, EventArgs e)
        {
            txtn1.Text = txtn1.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtn1.Text = txtn1.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtn1.Text = txtn1.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtn1.Text = txtn1.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtn1.Text = txtn1.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtn1.Text = txtn1.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtn1.Text = txtn1.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtn1.Text = txtn1.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtn1.Text = txtn1.Text + "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtn1.Text = txtn1.Text + "0";
        }

        private void btnsomar_Click(object sender, EventArgs e)
        {
            int n1;
            int n2;
            int resultado;
            n1 = int.Parse(txtn1.Text);
            n2 = int.Parse(txtn2.Text);
            resultado = n1 + n2;
            txtResultado.Text = resultado.ToString();
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            int n3;
            int n4;
            int resultado;
            n3 = int.Parse(txtN3.Text);
            n4 = int.Parse(txtN4.Text);
            resultado = n3 * n4;
            txtResultado2.Text = resultado.ToString();
        }
    }
}
      