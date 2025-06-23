namespace Cantina_11._0
{
    partial class Cozinha
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
            txtCozinha = new Label();
            listCozinha = new ListBox();
            txtEntreguesCozinha = new Label();
            listEntreguesCozinha = new ListBox();
            btnEntregar = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtCozinha
            // 
            txtCozinha.AutoSize = true;
            txtCozinha.Location = new Point(382, 120);
            txtCozinha.Name = "txtCozinha";
            txtCozinha.Size = new Size(50, 15);
            txtCozinha.TabIndex = 0;
            txtCozinha.Text = "Cozinha";
            // 
            // listCozinha
            // 
            listCozinha.FormattingEnabled = true;
            listCozinha.ItemHeight = 15;
            listCozinha.Location = new Point(46, 138);
            listCozinha.Name = "listCozinha";
            listCozinha.Size = new Size(709, 94);
            listCozinha.TabIndex = 1;
            // 
            // txtEntreguesCozinha
            // 
            txtEntreguesCozinha.AutoSize = true;
            txtEntreguesCozinha.Location = new Point(389, 326);
            txtEntreguesCozinha.Name = "txtEntreguesCozinha";
            txtEntreguesCozinha.Size = new Size(59, 15);
            txtEntreguesCozinha.TabIndex = 2;
            txtEntreguesCozinha.Text = "Entregues";
            // 
            // listEntreguesCozinha
            // 
            listEntreguesCozinha.FormattingEnabled = true;
            listEntreguesCozinha.ItemHeight = 15;
            listEntreguesCozinha.Location = new Point(46, 344);
            listEntreguesCozinha.Name = "listEntreguesCozinha";
            listEntreguesCozinha.Size = new Size(709, 94);
            listEntreguesCozinha.TabIndex = 3;
            // 
            // btnEntregar
            // 
            btnEntregar.Location = new Point(373, 250);
            btnEntregar.Name = "btnEntregar";
            btnEntregar.Size = new Size(75, 23);
            btnEntregar.TabIndex = 4;
            btnEntregar.Text = "Entregar";
            btnEntregar.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.bolt_logo;
            pictureBox1.Location = new Point(300, -19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(195, 125);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // Cozinha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 255, 0);
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(btnEntregar);
            Controls.Add(listEntreguesCozinha);
            Controls.Add(txtEntreguesCozinha);
            Controls.Add(listCozinha);
            Controls.Add(txtCozinha);
            Name = "Cozinha";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cozinha";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtCozinha;
        private ListBox listCozinha;
        private Label txtEntreguesCozinha;
        private ListBox listEntreguesCozinha;
        private Button btnEntregar;
        private PictureBox pictureBox1;
    }
}