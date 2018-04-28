using Entidade;
using System;
using System.Windows.Forms;
using DB;


namespace projLinguagem
{
    public partial class tela : Form
    {
        public tela()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Linguagem linguagem = new Linguagem();
            linguagem.Nome = txtNome.Text;
            linguagem.Pontuacao = Convert.ToInt32(txtPontuacao.Text);

            if (new LinguagemDB().insert(linguagem))
            {
                MessageBox.Show("Registro inserido!", "Inserido!");
            }
            else
            {
                MessageBox.Show("Erro ao inserir registro!", "Erro!");
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que seja sair?", "Sair", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
