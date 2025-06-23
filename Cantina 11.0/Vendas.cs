using System.Reflection;

namespace Cantina_11._0
{
    public partial class Vendas : Form
    {
        private List<Produto> produtos;
        private Carrinho carrinho;

        public Vendas()
        {
            carrinho = new Carrinho();
            InitializeComponent();
            listProdutos.DisplayMember = "Nome";
            listCarrinho.DisplayMember = "Nome";
            //listProdutos.DisplayMember = "Quantidade";
            listProdutos.Items.Add(new Produto { Nome = "Pão de Queijo (3,50)", Preco = 3.50, isChapa = true });
            listProdutos.Items.Add(new Produto { Nome = "Coxinha (5,00)", Preco = 5.00, isChapa = true });
            listProdutos.Items.Add(new Produto { Nome = "Pastel de Carne (6,00)", Preco = 6.00, isChapa = false });
            listProdutos.Items.Add(new Produto { Nome = "Pastel de Queijo (5,50)", Preco = 5.50, isChapa = false });
            listProdutos.Items.Add(new Produto { Nome = "Suco Natural (300mL) (4,00)", Preco = 4.00, isChapa = true });
            listProdutos.Items.Add(new Produto { Nome = "Refrigerante Lata (4,50)", Preco = 4.50, isChapa = true });
            listProdutos.Items.Add(new Produto { Nome = "Hambúrguer Simples (8,00)", Preco = 8.00, isChapa = false });
            listProdutos.Items.Add(new Produto { Nome = "Hambúrguer com Queijo (9,00)", Preco = 9.00, isChapa = false });
            listProdutos.Items.Add(new Produto { Nome = "X-Tudo (12,00)", Preco = 12.00, isChapa = false });
            listProdutos.Items.Add(new Produto { Nome = "Água Mineral (500mL) (2,50)", Preco = 2.50, isChapa = true });

            /*OBS: true = não vai para o preparo
                   false = vai para o preparo*/

            numericQuantidade.Minimum = 1;
            numericQuantidade.Maximum = 10;
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

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (listProdutos != null)
            {
                listCarrinho.Items.Add(listProdutos.SelectedItem);
                AtualizarTotal();
            }
        }

        private void AtualizarTotal()
        {
            lblValor.Text = $"Total: R${carrinho.Total():F2}";
        }
    }
}
