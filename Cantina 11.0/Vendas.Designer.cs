﻿namespace Cantina_11._0
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
            lblValor = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericQuantidade).BeginInit();
            SuspendLayout();
            // 
            // txtProdutos
            // 
            txtProdutos.AutoSize = true;
            txtProdutos.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtProdutos.Location = new Point(107, 144);
            txtProdutos.Name = "txtProdutos";
            txtProdutos.Size = new Size(77, 18);
            txtProdutos.TabIndex = 0;
            txtProdutos.Text = "Produtos";
            // 
            // txtCarrinho
            // 
            txtCarrinho.AutoSize = true;
            txtCarrinho.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCarrinho.Location = new Point(613, 144);
            txtCarrinho.Name = "txtCarrinho";
            txtCarrinho.Size = new Size(73, 18);
            txtCarrinho.TabIndex = 1;
            txtCarrinho.Text = "Carrinho";
            // 
            // txtCliente
            // 
            txtCliente.AutoSize = true;
            txtCliente.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCliente.Location = new Point(321, 171);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(60, 18);
            txtCliente.TabIndex = 2;
            txtCliente.Text = "Cliente";
            // 
            // txtDinheiro
            // 
            txtDinheiro.AutoSize = true;
            txtDinheiro.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDinheiro.Location = new Point(321, 310);
            txtDinheiro.Name = "txtDinheiro";
            txtDinheiro.Size = new Size(71, 18);
            txtDinheiro.TabIndex = 3;
            txtDinheiro.Text = "Dinheiro";
            txtDinheiro.Visible = false;
            // 
            // txtTroco
            // 
            txtTroco.AutoSize = true;
            txtTroco.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTroco.Location = new Point(330, 352);
            txtTroco.Name = "txtTroco";
            txtTroco.Size = new Size(53, 18);
            txtTroco.TabIndex = 4;
            txtTroco.Text = "Troco";
            txtTroco.Visible = false;
            // 
            // txtQuantidade
            // 
            txtQuantidade.AutoSize = true;
            txtQuantidade.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtQuantidade.Location = new Point(26, 335);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(93, 18);
            txtQuantidade.TabIndex = 5;
            txtQuantidade.Text = "Quantidade";
            // 
            // txtPagamento
            // 
            txtPagamento.AutoSize = true;
            txtPagamento.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPagamento.Location = new Point(26, 378);
            txtPagamento.Name = "txtPagamento";
            txtPagamento.Size = new Size(93, 18);
            txtPagamento.TabIndex = 6;
            txtPagamento.Text = "Pagamento";
            // 
            // btnAdicionar
            // 
            btnAdicionar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdicionar.Location = new Point(368, 220);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 23);
            btnAdicionar.TabIndex = 7;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnRemover
            // 
            btnRemover.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemover.Location = new Point(368, 258);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(75, 23);
            btnRemover.TabIndex = 8;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click;
            // 
            // btnEncerrar
            // 
            btnEncerrar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEncerrar.Location = new Point(330, 399);
            btnEncerrar.Name = "btnEncerrar";
            btnEncerrar.Size = new Size(141, 23);
            btnEncerrar.TabIndex = 9;
            btnEncerrar.Text = "Finalizar a compra";
            btnEncerrar.UseVisualStyleBackColor = true;
            btnEncerrar.Click += btnEncerrar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.raio;
            pictureBox1.Location = new Point(589, 378);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(223, 87);
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
            pictureBox3.Location = new Point(-16, -9);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(233, 87);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 14;
            pictureBox3.TabStop = false;
            // 
            // textDinheiro
            // 
            textDinheiro.Location = new Point(398, 312);
            textDinheiro.Name = "textDinheiro";
            textDinheiro.Size = new Size(100, 23);
            textDinheiro.TabIndex = 15;
            textDinheiro.Visible = false;
            // 
            // textTroco
            // 
            textTroco.Location = new Point(398, 354);
            textTroco.Name = "textTroco";
            textTroco.Size = new Size(100, 23);
            textTroco.TabIndex = 16;
            textTroco.Visible = false;
            // 
            // textCliente
            // 
            textCliente.Location = new Point(388, 173);
            textCliente.Name = "textCliente";
            textCliente.Size = new Size(100, 23);
            textCliente.TabIndex = 17;
            // 
            // numericQuantidade
            // 
            numericQuantidade.Location = new Point(126, 338);
            numericQuantidade.Name = "numericQuantidade";
            numericQuantidade.Size = new Size(121, 23);
            numericQuantidade.TabIndex = 18;
            // 
            // listProdutos
            // 
            listProdutos.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listProdutos.FormattingEnabled = true;
            listProdutos.ItemHeight = 15;
            listProdutos.Location = new Point(31, 173);
            listProdutos.Name = "listProdutos";
            listProdutos.Size = new Size(256, 154);
            listProdutos.TabIndex = 19;
            // 
            // listCarrinho
            // 
            listCarrinho.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listCarrinho.FormattingEnabled = true;
            listCarrinho.ItemHeight = 15;
            listCarrinho.Location = new Point(519, 173);
            listCarrinho.Name = "listCarrinho";
            listCarrinho.Size = new Size(256, 154);
            listCarrinho.TabIndex = 20;
            // 
            // comboPagamento
            // 
            comboPagamento.FormattingEnabled = true;
            comboPagamento.Items.AddRange(new object[] { "Dinheiro", "Crédito", "Débito", "Pix", "VR", "VA" });
            comboPagamento.Location = new Point(126, 380);
            comboPagamento.Name = "comboPagamento";
            comboPagamento.Size = new Size(121, 23);
            comboPagamento.TabIndex = 21;
            comboPagamento.SelectedIndexChanged += comboPagamento_SelectedIndexChanged;
            // 
            // checkViagem
            // 
            checkViagem.AutoSize = true;
            checkViagem.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkViagem.Location = new Point(72, 409);
            checkViagem.Name = "checkViagem";
            checkViagem.Size = new Size(144, 28);
            checkViagem.TabIndex = 22;
            checkViagem.Text = "Para viagem";
            checkViagem.UseVisualStyleBackColor = true;
            checkViagem.CheckedChanged += checkViagem_CheckedChanged;
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblValor.Location = new Point(592, 338);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(100, 25);
            lblValor.TabIndex = 23;
            lblValor.Text = "Total: R$";
            // 
            // Vendas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 255, 0);
            ClientSize = new Size(800, 450);
            Controls.Add(lblValor);
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
        private Label lblValor;
    }
}
