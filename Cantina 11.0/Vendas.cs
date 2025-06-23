namespace Cantina_11._0
{
    public partial class Vendas : Form
    {
        public Vendas()
        {
            InitializeComponent();
        }

        private void btnBalcao_Click(object sender, EventArgs e)
        {
            Login minhaNovaJanela = new Login();
            minhaNovaJanela.Show();
        }

        private void btnCozinha_Click(object sender, EventArgs e)
        {
            Login minhaNovaJanela = new Login();
            minhaNovaJanela.Show();
        }
    }
}
