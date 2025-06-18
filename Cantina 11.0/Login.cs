using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cantina_11._0
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string usuario = textUsuario.Text;
            string senha = textSenha.Text;

            if (usuario == "Vendas" && senha == "vendas123")
            {
                progressBar.Minimum = 0;
                progressBar.Maximum = 20000;
                progressBar.Visible = true;

                for (int i = 0; i <= 20000; i++)
                {
                    progressBar.Value = i;
                }
                progressBar.Visible = false;
                Vendas minhaNovaJanela = new Vendas();
                minhaNovaJanela.Show();
                textUsuario.Clear();
                textSenha.Clear();
            }
            else if (usuario == "Balcão" && senha == "balcão123")
            {
                progressBar.Minimum = 0;
                progressBar.Maximum = 20000;
                progressBar.Visible = true;

                for (int i = 0; i <= 20000; i++)
                {
                    progressBar.Value = i;
                }

                progressBar.Visible = false;
                Balcão minhaNovaJanela = new Balcão();
                minhaNovaJanela.Show();
                textUsuario.Clear();
                textSenha.Clear();
            }
            else if (usuario == "Cozinha" && senha == "cozinha123")
            {
                progressBar.Minimum = 0;
                progressBar.Maximum = 20000;
                progressBar.Visible = true;

                for (int i = 0; i <= 20000; i++)
                {
                    progressBar.Value = i;
                }

                progressBar.Visible = false;
                Cozinha minhaNovaJanela = new Cozinha();
                minhaNovaJanela.Show();
                textUsuario.Clear();
                textSenha.Clear();
            }
            else if (usuario == string.Empty && senha == string.Empty)
            {
                MessageBox.Show("Insira o usuário e senha!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textUsuario.Clear();
                textSenha.Clear();
            }
        }

        private void textUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
