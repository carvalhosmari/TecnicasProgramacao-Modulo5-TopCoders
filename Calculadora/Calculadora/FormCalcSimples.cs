using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Calculadora
{
    public partial class FormCalcSimples : Form
    {
        public FormCalcSimples()
        {
            InitializeComponent();
        }

        private void FormCalcSimples_Load(object sender, EventArgs e)
        {
            txbDisplay.Text = "";
            txbDisplay.Focus();
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            txbDisplay.Text = "";
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            txbDisplay.Text = txbDisplay.Text + "1";
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            txbDisplay.Text = txbDisplay.Text + "2";
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            txbDisplay.Text = txbDisplay.Text + "3";
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            txbDisplay.Text = txbDisplay.Text + "4";
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            txbDisplay.Text = txbDisplay.Text + "5";
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            txbDisplay.Text = txbDisplay.Text + "6";
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            txbDisplay.Text = txbDisplay.Text + "7";
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            txbDisplay.Text = txbDisplay.Text + "8";
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            txbDisplay.Text = txbDisplay.Text + "9";
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            txbDisplay.Text = txbDisplay.Text + "0";
        }

        private void BtnPonto_Click(object sender, EventArgs e)
        {
            txbDisplay.Text = txbDisplay.Text + ".";
        }

        private void BtnAdicao_Click(object sender, EventArgs e)
        {
            txbDisplay.Text = txbDisplay.Text + " + ";
        }

        private void BtnSubt_Click(object sender, EventArgs e)
        {
            txbDisplay.Text = txbDisplay.Text + " - ";
        }

        private void BtnMult_Click(object sender, EventArgs e)
        {
            txbDisplay.Text = txbDisplay.Text + " * ";
        }

        private void BtnDiv_Click(object sender, EventArgs e)
        {
            txbDisplay.Text = txbDisplay.Text + " / ";
        }

        private void BtnResultado_Click(object sender, EventArgs e)
        {
            DataTable Calc = new DataTable();

            var result = Calc.Compute(txbDisplay.Text, " ");

            txbDisplay.Text = result.ToString();
        }


    }
}
