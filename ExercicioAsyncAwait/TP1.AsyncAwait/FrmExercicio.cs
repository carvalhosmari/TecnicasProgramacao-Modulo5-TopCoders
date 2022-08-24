using System.Diagnostics;

namespace TP1.AsyncAwait
{
    public partial class FrmExercicio : Form
    {
        public FrmExercicio()
        {
            InitializeComponent();
        }

        private async void btnCalcular_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();

            btnCalcular.Enabled = false;
            lblProcessamento.Text = "";

            var task1 = CalculaFolhaPgto();
            var task2 = CalculaImpostos();
            var task3 = CalculaReceita();
            var task4 = CalculaDespesa();

            await task1;
            await task2;
            await task3;
            await task4;

            stopwatch.Stop();

            lblProcessamento.Text = $"Tempo de processamento: {stopwatch.Elapsed.Seconds}s";
            btnCalcular.Enabled = true;
        }

        private async Task CalculaFolhaPgto()
        {
            lblCalcPagamento.ForeColor = Color.Red;
            lblCalcPagamento.Text = "calculando..";
            await Task.Delay(TimeSpan.FromSeconds(2));
            lblCalcPagamento.ForeColor = Color.Green;
            lblCalcPagamento.Text = "R$12500,00";
        }

        private async Task CalculaImpostos()
        {
            lblCalcImposto.ForeColor = Color.Red;
            lblCalcImposto.Text = "calculando..";
            await Task.Delay(TimeSpan.FromSeconds(3));
            lblCalcImposto.ForeColor = Color.Green;
            lblCalcImposto.Text = "R$3375,00";
        }

        private async Task CalculaReceita()
        {
            lblCalcReceita.ForeColor = Color.Red;
            lblCalcReceita.Text = "calculando..";
            await Task.Delay(TimeSpan.FromSeconds(5));
            lblCalcReceita.ForeColor = Color.Green;
            lblCalcReceita.Text = "R$5600,00";
        }

        private async Task CalculaDespesa()
        {
            lblCalcDespesa.ForeColor = Color.Red;
            lblCalcDespesa.Text = "calculando..";
            await Task.Delay(TimeSpan.FromSeconds(4));
            lblCalcDespesa.ForeColor = Color.Green;
            lblCalcDespesa.Text = "R$7800,00";
        }
    }
}