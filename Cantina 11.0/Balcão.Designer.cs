namespace Cantina_11._0
{
    partial class Balcão
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            txtPedidos = new Label();
            listPedidos = new ListBox();
            txtEntregues = new Label();
            listEntregues = new ListBox();
            btnEntregar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.bolt_logo;
            pictureBox1.Location = new Point(303, -24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 139);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txtPedidos
            // 
            txtPedidos.AutoSize = true;
            txtPedidos.Font = new Font("Inter SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPedidos.Location = new Point(369, 125);
            txtPedidos.Name = "txtPedidos";
            txtPedidos.Size = new Size(68, 22);
            txtPedidos.TabIndex = 1;
            txtPedidos.Text = "Pedidos";
            // 
            // listPedidos
            // 
            listPedidos.FormattingEnabled = true;
            listPedidos.ItemHeight = 15;
            listPedidos.Location = new Point(42, 150);
            listPedidos.Name = "listPedidos";
            listPedidos.Size = new Size(714, 94);
            listPedidos.TabIndex = 2;
            // 
            // txtEntregues
            // 
            txtEntregues.AutoSize = true;
            txtEntregues.Font = new Font("Inter SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEntregues.Location = new Point(361, 310);
            txtEntregues.Name = "txtEntregues";
            txtEntregues.Size = new Size(83, 22);
            txtEntregues.TabIndex = 3;
            txtEntregues.Text = "Entregues";
            // 
            // listEntregues
            // 
            listEntregues.FormattingEnabled = true;
            listEntregues.ItemHeight = 15;
            listEntregues.Location = new Point(42, 335);
            listEntregues.Name = "listEntregues";
            listEntregues.Size = new Size(714, 94);
            listEntregues.TabIndex = 4;
            // 
            // btnEntregar
            // 
            btnEntregar.Location = new Point(369, 260);
            btnEntregar.Name = "btnEntregar";
            btnEntregar.Size = new Size(75, 23);
            btnEntregar.TabIndex = 5;
            btnEntregar.Text = "Entregar";
            btnEntregar.UseVisualStyleBackColor = true;
            // 
            // Balcão
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 255, 0);
            ClientSize = new Size(800, 450);
            Controls.Add(btnEntregar);
            Controls.Add(listEntregues);
            Controls.Add(txtEntregues);
            Controls.Add(listPedidos);
            Controls.Add(txtPedidos);
            Controls.Add(pictureBox1);
            Name = "Balcão";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Balcão";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label txtPedidos;
        private ListBox listPedidos;
        private Label txtEntregues;
        private ListBox listEntregues;
        private Button btnEntregar;
    }
}