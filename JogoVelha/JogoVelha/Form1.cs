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

        //:: Modo de jogo
        //:: Usado em caso de trocar modo para zerar a pontuação
        //> false para contra IA
        private bool modoJogo = false;
        public bool ModoJogo { get => modoJogo; set => modoJogo = value; }

        //:: Instância a Classe JogaVs e IAJoga
        JogaVS vs = new JogaVS();
        IAJoga iaJoga = new IAJoga();
       
        //:: Instância a Classe Tabuleiro
        Tabuleiro tabuleiro = new Tabuleiro();
        
        //:: Variaveis de pontuação
        private int empataPontos = 0;
        private int xPontos = 0;
        private int oPontos = 0;
        private int EmpatePontos { get => empataPontos; set => empataPontos = value; }
        private int XPontos { get => xPontos; set => xPontos = value; }
        private int OPontos { get => oPontos; set => oPontos = value; }

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
                    "se for contra outra pessoa digitar o nome dela.\r\n"+
                    "E clique em INICIAR."
                    );
                erro.ShowDialog();
                return;
            }
            //:: Guarda quem joga
            string quemJoga = vs.VezDeJogar;
            //:: Verifica se lugar no tabuleiro está vazio
            int lugar = tabuleiro.LugarVazio(((PictureBox)sender).Name);
            //:: lugar no tabuleiro já ocupado não faz nada
            if (lugar == -1) { return; }
            //:: Se estiver vazio coloca peça da vez nele
            tabuleiro.LugarTabuleiro[lugar] = quemJoga == "vp1" ? 'X' : 'O';
            ((PictureBox)sender).Image = quemJoga == "vp1" ? Properties.Resources.pv_X : Properties.Resources.pv_O;
            vezJogarXO.Image = quemJoga == "vp2" ? Properties.Resources.pv_X : Properties.Resources.pv_O;
            vs.VezDeJogar = quemJoga == "vp1" ? "vp2" : "vp1";
            //:: Checa se fez a velha
            //:: Caso sim faz a pontuação e reseta o jogo
            if (vs.ChecarVelha(quemJoga == "vp1" ? 'X' : 'O'))
            {
                Mensagem nv = new Mensagem(quemJoga == "vp1" ? 'X' : 'O', quemJoga == "vp1" ? txtJogador1.Text : rbPessoa.Checked ? txtJogador2.Text: "Computador");
                nv.ShowDialog();
                if (quemJoga == "vp1") { XPontos++; }
                if (quemJoga == "vp2") { OPontos++; }
                vs.VezDeJogar = quemJoga == "vp1" ? "vp1" : "vp2";
                ReseteJogo();
                return;
            }
            //:: IA jogando caso estejá ligado
            if (rbComputador.Checked)
            {
                //:: Faz as checagens de ataque, defesa e jogar aleatório
                int iAataca = iaJoga.IAChecarVelha('O');
                int iAdefende = iAataca != -1 ? -1 : iaJoga.IAChecarVelha('X');
                int iAaleatorio = iAdefende == -1 ? iaJoga.IAaleatorio(): -1;
                //:: Armazena uma id para trocar imagem la no switch
                int iaImagem = 0;
                //:: Se tiver opção para atacar IA ataca
                if (iAataca != -1)
                {
                    tabuleiro.LugarTabuleiro[iAataca] = 'O';
                    iaImagem = iAataca;
                }
                //:: Se tiver opção para defesa IA defende
                else if (iAdefende != -1)
                {
                    tabuleiro.LugarTabuleiro[iAdefende] = 'O';
                    iaImagem = iAdefende;
                }
                //:: IA joga aleatório
                else if (iAataca == -1 && iAdefende == -1 && iAaleatorio != -1)
                {
                    tabuleiro.LugarTabuleiro[iAaleatorio] = 'O';
                    iaImagem = iAaleatorio;
                }
                //:: Coloca imagem da peça no tabuleiro
                switch (iaImagem)
                {
                    case 0: pc1.Image = Properties.Resources.pv_O; break;
                    case 1: pc2.Image = Properties.Resources.pv_O; break;
                    case 2: pc3.Image = Properties.Resources.pv_O; break;
                    case 3: pc4.Image = Properties.Resources.pv_O; break;
                    case 4: pc5.Image = Properties.Resources.pv_O; break;
                    case 5: pc6.Image = Properties.Resources.pv_O; break;
                    case 6: pc7.Image = Properties.Resources.pv_O; break;
                    case 7: pc8.Image = Properties.Resources.pv_O; break;
                    case 8: pc9.Image = Properties.Resources.pv_O; break;
                }
                //:: Atualiza jogada da Ia no tabuleiro
                vezJogarXO.Image = Properties.Resources.pv_X;
                //:: Checa se Ia fez a velha
                if (vs.ChecarVelha('O'))
                {
                    Mensagem nv = new Mensagem('O', "Computador");
                    nv.ShowDialog();
                    OPontos++;
                    ReseteJogo();
                }
                //:: Passa vez para jogador
                vs.VezDeJogar = "vp1";
            }
            //:: Checa se de empate
            //:: Caso sim faz a pontuação e reseta o jogo
            if (tabuleiro.Empate() == 9)
            {
                Erros erro = new Erros("O jogo deu velha!!!");
                erro.ShowDialog();
                EmpatePontos++;
                ReseteJogo();
                return;
            }
        }

        private void ReseteJogo()
        {
            IniciarJogo = false;
            btIniciar.Enabled = true;
            gbOpcoes.Enabled = true;
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
            vezJogarXO.Image = vs.VezDeJogar == "vp1" ? Properties.Resources.pv_X : Properties.Resources.pv_O;
            //:: Mostar a pontução
            lbEmpate.Text = EmpatePontos.ToString();
            lbO.Text = OPontos.ToString();
            lbX.Text = XPontos.ToString();
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

            //:: se mudar de modo zera pontuação
            if(rbComputador.Checked && ModoJogo)
            {
                ModoJogo = false;
                XPontos = 0;
                OPontos = 0;
                EmpatePontos = 0;
                //:: Mostar a pontução
                lbEmpate.Text = EmpatePontos.ToString();
                lbO.Text = OPontos.ToString();
                lbX.Text = XPontos.ToString();
            }
            if (rbPessoa.Checked && !ModoJogo)
            {
                ModoJogo = true;
                XPontos = 0;
                OPontos = 0;
                EmpatePontos = 0;
                //:: Mostar a pontução
                lbEmpate.Text = EmpatePontos.ToString();
                lbO.Text = OPontos.ToString();
                lbX.Text = XPontos.ToString();
            }
            
            gbOpcoes.Enabled = false;
            txtJogador1.Enabled = false;
            txtJogador2.Enabled = false;
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
            txtJogador1.Enabled = true;
            txtJogador2.Enabled = true;
        }

        private void blBotaoFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Informativo inf = new Informativo();
            inf.ShowDialog();
        }
    }
}
