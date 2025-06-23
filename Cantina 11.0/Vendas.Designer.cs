namespace Cantina_11._0
{
    partial class Vendas
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtProdutos = new Label();
            txtCarrinho = new Label();
            txtCliente = new Label();
            txtDinheiro = new Label();
            txtTroco = new Label();
            txtQuantidade = new Label();
            txtPagamento = new Label();
            btnAdicionar = new Button();
            btnRemover = new Button();
            btnEncerrar = new Button();
            btnBalcao = new Button();
            btnCozinha = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            textDinheiro = new TextBox();
            textTroco = new TextBox();
            textCliente = new TextBox();
            numericQuantidade = new NumericUpDown();
            listProdutos = new ListBox();
            listCarrinho = new ListBox();
            comboPagamento = new ComboBox();
            checkViagem = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericQuantidade).BeginInit();
            SuspendLayout();
            // 
            // txtProdutos
            // 
            txtProdutos.AutoSize = true;
            txtProdutos.Location = new Point(132, 144);
            txtProdutos.Name = "txtProdutos";
            txtProdutos.Size = new Size(55, 15);
            txtProdutos.TabIndex = 0;
            txtProdutos.Text = "Produtos";
            // 
            // txtCarrinho
            // 
            txtCarrinho.AutoSize = true;
            txtCarrinho.Location = new Point(622, 144);
            txtCarrinho.Name = "txtCarrinho";
            txtCarrinho.Size = new Size(53, 15);
            txtCarrinho.TabIndex = 1;
            txtCarrinho.Text = "Carrinho";
            // 
            // txtCliente
            // 
            txtCliente.AutoSize = true;
            txtCliente.Location = new Point(330, 173);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(44, 15);
            txtCliente.TabIndex = 2;
            txtCliente.Text = "Cliente";
            // 
            // txtDinheiro
            // 
            txtDinheiro.AutoSize = true;
            txtDinheiro.Location = new Point(330, 312);
            txtDinheiro.Name = "txtDinheiro";
            txtDinheiro.Size = new Size(52, 15);
            txtDinheiro.TabIndex = 3;
            txtDinheiro.Text = "Dinheiro";
            txtDinheiro.Visible = false;
            // 
            // txtTroco
            // 
            txtTroco.AutoSize = true;
            txtTroco.Location = new Point(330, 352);
            txtTroco.Name = "txtTroco";
            txtTroco.Size = new Size(36, 15);
            txtTroco.TabIndex = 4;
            txtTroco.Text = "Troco";
            txtTroco.Visible = false;
            // 
            // txtQuantidade
            // 
            txtQuantidade.AutoSize = true;
            txtQuantidade.Location = new Point(31, 335);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(69, 15);
            txtQuantidade.TabIndex = 5;
            txtQuantidade.Text = "Quantidade";
            // 
            // txtPagamento
            // 
            txtPagamento.AutoSize = true;
            txtPagamento.Location = new Point(26, 378);
            txtPagamento.Name = "txtPagamento";
            txtPagamento.Size = new Size(68, 15);
            txtPagamento.TabIndex = 6;
            txtPagamento.Text = "Pagamento";
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(368, 215);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 23);
            btnAdicionar.TabIndex = 7;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(368, 258);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(75, 23);
            btnRemover.TabIndex = 8;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = true;
            // 
            // btnEncerrar
            // 
            btnEncerrar.Location = new Point(357, 398);
            btnEncerrar.Name = "btnEncerrar";
            btnEncerrar.Size = new Size(119, 23);
            btnEncerrar.TabIndex = 9;
            btnEncerrar.Text = "Finalizar a compra";
            btnEncerrar.UseVisualStyleBackColor = true;
            // 
            // btnBalcao
            // 
            btnBalcao.Location = new Point(589, 33);
            btnBalcao.Name = "btnBalcao";
            btnBalcao.Size = new Size(75, 23);
            btnBalcao.TabIndex = 10;
            btnBalcao.Text = "Balcão";
            btnBalcao.UseVisualStyleBackColor = true;
            btnBalcao.Click += btnBalcao_Click;
            // 
            // btnCozinha
            // 
            btnCozinha.Location = new Point(685, 33);
            btnCozinha.Name = "btnCozinha";
            btnCozinha.Size = new Size(75, 23);
            btnCozinha.TabIndex = 11;
            btnCozinha.Text = "Cozinha";
            btnCozinha.UseVisualStyleBackColor = true;
            btnCozinha.Click += btnCozinha_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.raio;
            pictureBox1.Location = new Point(559, 335);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(253, 130);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.bolt_logo;
            pictureBox2.Location = new Point(291, -18);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(245, 158);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.raio_2;
            pictureBox3.Location = new Point(-14, -18);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(253, 130);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 14;
            pictureBox3.TabStop = false;
            // 
            // textDinheiro
            // 
            textDinheiro.Location = new Point(387, 309);
            textDinheiro.Name = "textDinheiro";
            textDinheiro.Size = new Size(100, 23);
            textDinheiro.TabIndex = 15;
            textDinheiro.Visible = false;
            // 
            // textTroco
            // 
            textTroco.Location = new Point(387, 349);
            textTroco.Name = "textTroco";
            textTroco.Size = new Size(100, 23);
            textTroco.TabIndex = 16;
            textTroco.Visible = false;
            // 
            // textCliente
            // 
            textCliente.Location = new Point(387, 170);
            textCliente.Name = "textCliente";
            textCliente.Size = new Size(100, 23);
            textCliente.TabIndex = 17;
            // 
            // numericQuantidade
            // 
            numericQuantidade.Location = new Point(106, 333);
            numericQuantidade.Name = "numericQuantidade";
            numericQuantidade.Size = new Size(120, 23);
            numericQuantidade.TabIndex = 18;
            // 
            // listProdutos
            // 
            listProdutos.FormattingEnabled = true;
            listProdutos.ItemHeight = 15;
            listProdutos.Location = new Point(31, 173);
            listProdutos.Name = "listProdutos";
            listProdutos.Size = new Size(256, 139);
            listProdutos.TabIndex = 19;
            // 
            // listCarrinho
            // 
            listCarrinho.FormattingEnabled = true;
            listCarrinho.ItemHeight = 15;
            listCarrinho.Location = new Point(519, 173);
            listCarrinho.Name = "listCarrinho";
            listCarrinho.Size = new Size(256, 139);
            listCarrinho.TabIndex = 20;
            // 
            // comboPagamento
            // 
            comboPagamento.FormattingEnabled = true;
            comboPagamento.Location = new Point(100, 375);
            comboPagamento.Name = "comboPagamento";
            comboPagamento.Size = new Size(121, 23);
            comboPagamento.TabIndex = 21;
            // 
            // checkViagem
            // 
            checkViagem.AutoSize = true;
            checkViagem.Location = new Point(107, 419);
            checkViagem.Name = "checkViagem";
            checkViagem.Size = new Size(91, 19);
            checkViagem.TabIndex = 22;
            checkViagem.Text = "Para viagem";
            checkViagem.UseVisualStyleBackColor = true;
            // 
            // Vendas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 255, 0);
            ClientSize = new Size(800, 450);
            Controls.Add(checkViagem);
            Controls.Add(comboPagamento);
            Controls.Add(listCarrinho);
            Controls.Add(listProdutos);
            Controls.Add(numericQuantidade);
            Controls.Add(textCliente);
            Controls.Add(textTroco);
            Controls.Add(textDinheiro);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnCozinha);
            Controls.Add(btnBalcao);
            Controls.Add(btnEncerrar);
            Controls.Add(btnRemover);
            Controls.Add(btnAdicionar);
            Controls.Add(txtPagamento);
            Controls.Add(txtQuantidade);
            Controls.Add(txtTroco);
            Controls.Add(txtDinheiro);
            Controls.Add(txtCliente);
            Controls.Add(txtCarrinho);
            Controls.Add(txtProdutos);
            Name = "Vendas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Vendas";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericQuantidade).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtProdutos;
        private Label txtCarrinho;
        private Label txtCliente;
        private Label txtDinheiro;
        private Label txtTroco;
        private Label txtQuantidade;
        private Label txtPagamento;
        private Button btnAdicionar;
        private Button btnRemover;
        private Button btnEncerrar;
        private Button btnBalcao;
        private Button btnCozinha;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private TextBox textDinheiro;
        private TextBox textTroco;
        private TextBox textCliente;
        private NumericUpDown numericQuantidade;
        private ListBox listProdutos;
        private ListBox listCarrinho;
        private ComboBox comboPagamento;
        private CheckBox checkViagem;
    }
}
