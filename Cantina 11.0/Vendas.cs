using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            listCarrinho.DisplayMember = "ToString";

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

            textDinheiro.TextChanged += TextDinheiro_TextChanged;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (listProdutos.SelectedItem is Produto produtoSelecionado)
            {
                int quantidade = (int)numericQuantidade.Value;
                var novoProduto = new Produto
                {
                    Nome = produtoSelecionado.Nome,
                    Preco = produtoSelecionado.Preco * quantidade,
                    Quantidade = quantidade,
                    //isChapa = produtoSelecionado.isChapa
                };

                listCarrinho.Items.Add(novoProduto);
                carrinho.Adicionar(novoProduto);
                AtualizarTotal();
                
                TextDinheiro_TextChanged(null, null);
            }
            else
            {
                MessageBox.Show("Selecione um produto para adicionar no carrinho!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AtualizarTotal()
        {
            lblValor.Text = $"Total: R${carrinho.Total():F2}";
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (listCarrinho.SelectedItem is Produto produtoSelecionado)
            {
                carrinho.Remover(produtoSelecionado);
                listCarrinho.Items.Remove(produtoSelecionado);
                AtualizarTotal();
               
                TextDinheiro_TextChanged(null, null);
            }
            else
            {
                MessageBox.Show("Selecione um produto do carrinho antes de remover!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        
        public DateTime DataHora { get; set; }

        private void btnEncerrar_Click(object sender, EventArgs e)
        {
            string nomeDoCliente = textCliente.Text;
            string mensagemAdicional = ""; 
            double valorPago = 0;
            double totalCompra = carrinho.Total();
            string formaPagamento = comboPagamento.Text; 
            double trocoCalculado = 0;

            DataHora = DateTime.Now; 

            if (listCarrinho.Items.Count == 0)
            {
                MessageBox.Show("Carrinho vazio, impossível finalizar a compra.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(nomeDoCliente))
            {
                MessageBox.Show("Por favor, digite o nome do cliente!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (comboPagamento.SelectedIndex == -1) 
            {
                MessageBox.Show("Por favor, selecione uma forma de pagamento", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (comboPagamento.SelectedIndex == 0) 
            {
                if (!double.TryParse(textDinheiro.Text, out valorPago) || valorPago < totalCompra)
                {
                    MessageBox.Show("Valor pago inválido ou insuficiente para cobrir o total.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                trocoCalculado = valorPago - totalCompra;
            }

            if (checkViagem.Checked == true)
            {
                mensagemAdicional = "Pedido para viagem.";
            }
            else
            {
                mensagemAdicional = "Pedido para comer no local.";
            }

            
            string mensagemExtrato =
                "               ***** Extrato *****\n" +
                $"Nome do cliente: {nomeDoCliente}\n" +
                "Itens do pedido:\n" +
                $"{carrinho.Listar()}\n" + 
                $"\nTotal: R${carrinho.Total():F2}\n" +
                $"Forma de pagamento: {formaPagamento}\n";

            if (comboPagamento.SelectedIndex == 0) 
            {
                mensagemExtrato += $"Troco: R${trocoCalculado:F2}\n";
            }
            else
            {
                mensagemExtrato += $"Troco: -\n"; 
            }

            mensagemExtrato +=
                $"{mensagemAdicional}\n" +
                $"Data e hora: {DataHora:dd/MM/yyyy HH:mm:ss}\n";

            MessageBox.Show(mensagemExtrato, "Compra finalizada", MessageBoxButtons.OK);
            
            listCarrinho.Items.Clear();
            carrinho = new Carrinho(); 
            AtualizarTotal();
            textCliente.Clear();
            textDinheiro.Clear();
            textTroco.Clear();
            comboPagamento.SelectedIndex = -1;
            numericQuantidade.Value = numericQuantidade.Minimum;
            checkViagem.Checked = false;
        }

        private double calcularTroco()
        {
            double valorPago = 0;
            if (string.IsNullOrEmpty(textDinheiro.Text))
            {
                return 0;
            }

            if (!double.TryParse(textDinheiro.Text, out valorPago))
            {
                return -1;
            }
            double totalCompra = carrinho.Total();
            double troco = valorPago - totalCompra;
            return troco;
        }

        private void TextDinheiro_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textDinheiro.Text))
            {
                textTroco.Text = "R$ 0,00";
                return;
            }

            double troco = calcularTroco();

            if (troco >= 0)
            {
                textTroco.Text = $"R$ {troco:F2}";
            }
            else
            {
                if (troco == -1)
                {
                    textTroco.Text = "R$ 0,00";
                }
                else
                {
                    textTroco.Text = $"R$ 0,00";
                }
            }
        }

        private void comboPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboPagamento.SelectedIndex == 0)
            {
                txtDinheiro.Visible = true;
                textDinheiro.Visible = true;
                txtTroco.Visible = true;
                textTroco.Visible = true;
                TextDinheiro_TextChanged(null, null);
            }
            else
            {
                txtDinheiro.Visible = false;
                textDinheiro.Visible = false;
                txtTroco.Visible = false;
                textTroco.Visible = false;
                textTroco.Text = "R$ 0,00";
                textDinheiro.Text = "";
            }
        }

        private void checkViagem_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}