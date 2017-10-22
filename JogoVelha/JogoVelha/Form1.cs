using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace JogoVelha
{
    public partial class Velha : Form
    {
        public Velha()
        {
            InitializeComponent();
        }
        //:: Iniciar jogo
        private bool iniciarJogo = false;
        public bool IniciarJogo { get => iniciarJogo; set => iniciarJogo = value; }

        //:: Instância a Classe JogaVs
        JogaVS vs = new JogaVS();
       
        //:: Instância a Classe Tabuleiro
        Tabuleiro tabuleiro = new Tabuleiro();

        #region Move Janela
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void moveJ(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion

        //:: Cria e evento click nos botões do tabuleiro
        private void Velha_Load(object sender, EventArgs e)
        {
            pc1.Click += new EventHandler(BtClick_Click);
            pc2.Click += new EventHandler(BtClick_Click);
            pc3.Click += new EventHandler(BtClick_Click);
            pc4.Click += new EventHandler(BtClick_Click);
            pc5.Click += new EventHandler(BtClick_Click);
            pc6.Click += new EventHandler(BtClick_Click);
            pc7.Click += new EventHandler(BtClick_Click);
            pc8.Click += new EventHandler(BtClick_Click);
            pc9.Click += new EventHandler(BtClick_Click);
        }

        //:: Ao clicar em algum botão realiza a jogada para o jogador da vez
        //:: Caso sejá contra IA a jogada feita por Ia será em seguida do Jogador
        private void BtClick_Click(object sender, EventArgs e)
        {
            //:: Se não iniciou o jogo retorna
            if (!IniciarJogo)
            {
                Erros erro = new Erros(
                    "Para iniciar o jogo você tem que:\r\n" +
                    "Digitar seu Nome, " +
                    "escolher modo de jogo e " +
                    "se for contra outra pessoa digitar o nome dela."
                    );
                erro.ShowDialog();
                return;
            }

            string quemJoga = vs.VezDeJogar;
            //:: Verifica se lugar no tabuleiro esrá vazio
            int lugar = tabuleiro.LugarVazio(((PictureBox)sender).Name);

            //:: lugar no tabuleiro já ocupado não faz nada
            if (lugar == -1) { return; }
            
            //:: Se estiver vazio coloca peça da vez nele
            tabuleiro.LugarTabuleiro[lugar] = quemJoga == "vp1" ? 'X' : 'O';
            ((PictureBox)sender).Image = quemJoga == "vp1" ? Properties.Resources.pv_X : Properties.Resources.pv_O;
            vezJogarXO.Image = quemJoga == "vp2" ? Properties.Resources.pv_X : Properties.Resources.pv_O;
            vs.VezDeJogar = quemJoga == "vp1" ? "vp2" : "vp1";

            if (vs.ChecarVelha(quemJoga == "vp1" ? 'X' : 'O'))
            {
                Mensagem nv = new Mensagem(quemJoga == "vp1" ? 'X' : 'O', quemJoga == "vp1" ? txtJogador1.Text : rbPessoa.Checked ? txtJogador2.Text: "Computador");
                nv.ShowDialog();

                IniciarJogo = false;
                btIniciar.Enabled = true;
                //:: resetar o tabuleiro
                tabuleiro.ReseteTabuleiro();
                pc1.Image = null;
                pc2.Image = null;
                pc3.Image = null;
                pc4.Image = null;
                pc5.Image = null;
                pc6.Image = null;
                pc7.Image = null;
                pc8.Image = null;
                pc9.Image = null;
                vs.VezDeJogar = quemJoga == "vp1" ? "vp1" : "vp2";
                vezJogarXO.Image = quemJoga == "vp1" ? Properties.Resources.pv_X : Properties.Resources.pv_O;
            }
        }

        private void btIniciar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtJogador1.Text))
            {
                Erros erro = new Erros("Você precisa informar seu nome.");
                erro.ShowDialog();
                return;
            }
            if (rbPessoa.Checked && string.IsNullOrWhiteSpace(txtJogador2.Text))
            {
                Erros erro = new Erros("Você precisa informar os 2 nomes");
                erro.ShowDialog();
                return;
            }
            gbOpcoes.Enabled = false;
            txtJogador1.Enabled = false;
            btIniciar.Enabled = false;
            IniciarJogo = true;
        }

        private void rbComputador_CheckedChanged(object sender, EventArgs e)
        {
            txtJogador2.Enabled = false;
            txtJogador2.Text = string.Empty;
        }

        private void rbPessoa_CheckedChanged(object sender, EventArgs e)
        {
            txtJogador2.Enabled = true;
        }

        private void blBotaoFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
