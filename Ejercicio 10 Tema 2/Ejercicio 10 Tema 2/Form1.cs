namespace Ejercicio_10_Tema_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BotonAPesetas_Click(object sender, EventArgs e)
        {
            const double EUROPTS = 16.386;
            double Euros;
            double ResultadoAPesetas;

            Euros = double.Parse(txtEuros.Text);

            ResultadoAPesetas = Euros * EUROPTS;

            txtPesetas.Text = ResultadoAPesetas.ToString();

        }

        private void BotonAEuros_Click(object sender, EventArgs e)
        {
            const double EUROPTS = 166.386;
            double Pesetas;
            double ResultadoAEuros;

            try
            {
                Pesetas = double.Parse(txtPesetas.Text);

                ResultadoAEuros = Pesetas - EUROPTS;

                txtEuros.Text = ResultadoAEuros.ToString();
            }
            catch(FormatException fEx)
            {
                MessageBox.Show("Se ha producido el error: " + fEx.Message);
            }

        }
    }
}