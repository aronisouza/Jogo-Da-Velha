using System;
using System.Windows.Forms;

namespace JogoVelha
{
    public partial class Erros : Form
    {
        public Erros(string _erro)
        {
            InitializeComponent();
            Erro = _erro;
            CarregarJanela();
        }
        
        private string Erro { get; set; }

        private void CarregarJanela()
        {
            lbMsg.Text = Erro;
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
