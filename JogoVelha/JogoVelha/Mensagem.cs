using System;
using System.Windows.Forms;

namespace JogoVelha
{
    public partial class Mensagem : Form
    {
        public Mensagem(char imagem, string nome)
        {
            InitializeComponent();
            Nome = nome;
            Imagem = imagem;
            JanelaLoad();
        }

        private string Nome { get; set; }
        private char Imagem { get; set; }

        private void JanelaLoad()
        {
            lbQuem.Text = Nome;
            pbImg.Image = Imagem == 'X' ? Properties.Resources.pv_X : Properties.Resources.pv_O;
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
