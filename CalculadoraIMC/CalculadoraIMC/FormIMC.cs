using System.Globalization;

namespace CalculadoraIMC
{
    public partial class FormIMC : Form
    {
        public FormIMC()
        {
            InitializeComponent();
        }

        private void FormIMC_Load(object sender, EventArgs e)
        {
            lblTitle.Text = "Calculadora IMC";
            txtBoxWeight.Focus();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal weight, height;

            weight = Convert.ToDecimal(txtBoxWeight.Text);
            height = Convert.ToDecimal(txtBoxHeight.Text) / 100;

            var (imcDescription, imcResult) = CalcularIMC(weight, height);

            lblResult.Text = @$"Faixa IMC: {imcDescription}
IMC: {imcResult.ToString("F2")}";

        }

        private (string, decimal) CalcularIMC(decimal weight, decimal height)
        {
            decimal imc = weight / (height * height);

            var result = imc switch
            {
                < 20 => "Abaixo do peso",
                >= 20 and < 25 => "Ideal",
                >= 25 and < 30 => "Sobre peso",
                >= 30 and < 40 => "Obeso",
                _ => "Obeso mórbido"
            };

            return (result, imc);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtBoxHeight.Clear();
            txtBoxWeight.Clear();
            lblResult.Text = String.Empty;

            txtBoxWeight.Focus();
        }
    }
}