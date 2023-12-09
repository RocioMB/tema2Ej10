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
            //!? RMB2324 Corregimos el valor de la constante
            const double EUROPTS = 166.386;
            double EurosRMB2324; //!? Variable Euros cambiada con mis iniciales
            double ResultadoAPesetas;

            EurosRMB2324 = double.Parse(txtEuros.Text);

            ResultadoAPesetas = EurosRMB2324 * EUROPTS;

            txtPesetas.Text = ResultadoAPesetas.ToString();

        }

        private void BotonAEuros_Click(object sender, EventArgs e)
        {
            const double EUROPTS = 166.386;
            double PesetasRMB2324; //!? Variable Pesetas cambiada con mis iniciales
            double ResultadoAEuros;

            try
            {
                PesetasRMB2324 = double.Parse(txtPesetas.Text);

                ResultadoAEuros = PesetasRMB2324 - EUROPTS;

                txtEuros.Text = ResultadoAEuros.ToString();
            }
            catch(FormatException fEx)
            {
                MessageBox.Show("Se ha producido el error: " + fEx.Message);
            }

        }
    }
}