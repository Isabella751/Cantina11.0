namespace Cantina_11._0
{
    partial class Login
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
            btnEntrar = new Button();
            pictureBox1 = new PictureBox();
            lblUsuario = new Label();
            lblSenha = new Label();
            textUsuario = new TextBox();
            textSenha = new TextBox();
            progressBar = new ProgressBar();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(372, 290);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(75, 23);
            btnEntrar.TabIndex = 0;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.bolt_logo;
            pictureBox1.Location = new Point(263, -29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(273, 180);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Inter SemiBold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(250, 182);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(84, 27);
            lblUsuario.TabIndex = 2;
            lblUsuario.Text = "Usuário";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Inter SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSenha.Location = new Point(264, 227);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(70, 27);
            lblSenha.TabIndex = 3;
            lblSenha.Text = "Senha";
            // 
            // textUsuario
            // 
            textUsuario.Location = new Point(340, 188);
            textUsuario.Name = "textUsuario";
            textUsuario.Size = new Size(196, 23);
            textUsuario.TabIndex = 4;
            textUsuario.TextChanged += textUsuario_TextChanged;
            // 
            // textSenha
            // 
            textSenha.Location = new Point(340, 233);
            textSenha.Name = "textSenha";
            textSenha.Size = new Size(196, 23);
            textSenha.TabIndex = 5;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(300, 390);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(208, 23);
            progressBar.TabIndex = 6;
            progressBar.Visible = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 255, 0);
            ClientSize = new Size(800, 450);
            Controls.Add(progressBar);
            Controls.Add(textSenha);
            Controls.Add(textUsuario);
            Controls.Add(lblSenha);
            Controls.Add(lblUsuario);
            Controls.Add(pictureBox1);
            Controls.Add(btnEntrar);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEntrar;
        private PictureBox pictureBox1;
        private Label lblUsuario;
        private Label lblSenha;
        private TextBox textUsuario;
        private TextBox textSenha;
        private ProgressBar progressBar;
    }
}