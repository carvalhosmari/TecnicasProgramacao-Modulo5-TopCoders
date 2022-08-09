namespace TP.Aula01
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = "LOGIN";
            txbUsuario.Focus();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            FormLogin.ActiveForm.Close();
        }
    }
}