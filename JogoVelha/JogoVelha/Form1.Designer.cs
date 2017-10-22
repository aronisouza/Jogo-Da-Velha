namespace JogoVelha
{
    partial class Velha
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Velha));
            this.panel1 = new System.Windows.Forms.Panel();
            this.painelBorda = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gbOpcoes = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbComputador = new System.Windows.Forms.RadioButton();
            this.rbPessoa = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtJogador2 = new System.Windows.Forms.TextBox();
            this.lbComputador = new System.Windows.Forms.Label();
            this.lbJogador = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtJogador1 = new System.Windows.Forms.TextBox();
            this.lbO = new System.Windows.Forms.Label();
            this.lbEmpate = new System.Windows.Forms.Label();
            this.lbX = new System.Windows.Forms.Label();
            this.blBotaoFechar = new System.Windows.Forms.Label();
            this.btIniciar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.vezJogarXO = new System.Windows.Forms.PictureBox();
            this.pc7 = new System.Windows.Forms.PictureBox();
            this.pc8 = new System.Windows.Forms.PictureBox();
            this.pc1 = new System.Windows.Forms.PictureBox();
            this.pc9 = new System.Windows.Forms.PictureBox();
            this.pc2 = new System.Windows.Forms.PictureBox();
            this.pc6 = new System.Windows.Forms.PictureBox();
            this.pc3 = new System.Windows.Forms.PictureBox();
            this.pc5 = new System.Windows.Forms.PictureBox();
            this.pc4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.painelBorda.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gbOpcoes.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vezJogarXO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.vezJogarXO);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btIniciar);
            this.panel1.Controls.Add(this.gbOpcoes);
            this.panel1.Controls.Add(this.pc7);
            this.panel1.Controls.Add(this.pc8);
            this.panel1.Controls.Add(this.pc1);
            this.panel1.Controls.Add(this.pc9);
            this.panel1.Controls.Add(this.pc2);
            this.panel1.Controls.Add(this.pc6);
            this.panel1.Controls.Add(this.pc3);
            this.panel1.Controls.Add(this.pc5);
            this.panel1.Controls.Add(this.pc4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.panel1.Location = new System.Drawing.Point(1, 124);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(549, 362);
            this.panel1.TabIndex = 9;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.moveJ);
            // 
            // painelBorda
            // 
            this.painelBorda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.painelBorda.Controls.Add(this.blBotaoFechar);
            this.painelBorda.Controls.Add(this.panel2);
            this.painelBorda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.painelBorda.Location = new System.Drawing.Point(0, 0);
            this.painelBorda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.painelBorda.Name = "painelBorda";
            this.painelBorda.Size = new System.Drawing.Size(551, 487);
            this.painelBorda.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.BurlyWood;
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.panel2.Location = new System.Drawing.Point(1, 1);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(549, 123);
            this.panel2.TabIndex = 0;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.moveJ);
            // 
            // gbOpcoes
            // 
            this.gbOpcoes.Controls.Add(this.rbPessoa);
            this.gbOpcoes.Controls.Add(this.rbComputador);
            this.gbOpcoes.Controls.Add(this.label1);
            this.gbOpcoes.Cursor = System.Windows.Forms.Cursors.Default;
            this.gbOpcoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOpcoes.Location = new System.Drawing.Point(372, 7);
            this.gbOpcoes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbOpcoes.Name = "gbOpcoes";
            this.gbOpcoes.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbOpcoes.Size = new System.Drawing.Size(163, 128);
            this.gbOpcoes.TabIndex = 9;
            this.gbOpcoes.TabStop = false;
            this.gbOpcoes.Text = "Modo de jogo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Contra quem?";
            // 
            // rbComputador
            // 
            this.rbComputador.AutoSize = true;
            this.rbComputador.Checked = true;
            this.rbComputador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbComputador.Location = new System.Drawing.Point(14, 94);
            this.rbComputador.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbComputador.Name = "rbComputador";
            this.rbComputador.Size = new System.Drawing.Size(100, 20);
            this.rbComputador.TabIndex = 1;
            this.rbComputador.TabStop = true;
            this.rbComputador.Text = "Computador";
            this.rbComputador.UseVisualStyleBackColor = true;
            this.rbComputador.CheckedChanged += new System.EventHandler(this.rbComputador_CheckedChanged);
            // 
            // rbPessoa
            // 
            this.rbPessoa.AutoSize = true;
            this.rbPessoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPessoa.Location = new System.Drawing.Point(14, 60);
            this.rbPessoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbPessoa.Name = "rbPessoa";
            this.rbPessoa.Size = new System.Drawing.Size(73, 20);
            this.rbPessoa.TabIndex = 1;
            this.rbPessoa.Text = "Pessoa";
            this.rbPessoa.UseVisualStyleBackColor = true;
            this.rbPessoa.CheckedChanged += new System.EventHandler(this.rbPessoa_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbJogador);
            this.groupBox2.Controls.Add(this.lbComputador);
            this.groupBox2.Controls.Add(this.txtJogador1);
            this.groupBox2.Controls.Add(this.txtJogador2);
            this.groupBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(8, 7);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(322, 107);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " JOGADORES ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbX);
            this.groupBox3.Controls.Add(this.lbEmpate);
            this.groupBox3.Controls.Add(this.lbO);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(340, 7);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(196, 107);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = " PONTUAÇÃO ";
            // 
            // txtJogador2
            // 
            this.txtJogador2.Enabled = false;
            this.txtJogador2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJogador2.Location = new System.Drawing.Point(117, 66);
            this.txtJogador2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtJogador2.MaxLength = 15;
            this.txtJogador2.Name = "txtJogador2";
            this.txtJogador2.Size = new System.Drawing.Size(193, 26);
            this.txtJogador2.TabIndex = 0;
            this.txtJogador2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbComputador
            // 
            this.lbComputador.AutoSize = true;
            this.lbComputador.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbComputador.Location = new System.Drawing.Point(11, 71);
            this.lbComputador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbComputador.Name = "lbComputador";
            this.lbComputador.Size = new System.Drawing.Size(99, 17);
            this.lbComputador.TabIndex = 1;
            this.lbComputador.Text = "Adverssário:";
            // 
            // lbJogador
            // 
            this.lbJogador.AutoSize = true;
            this.lbJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbJogador.Location = new System.Drawing.Point(11, 33);
            this.lbJogador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbJogador.Name = "lbJogador";
            this.lbJogador.Size = new System.Drawing.Size(87, 17);
            this.lbJogador.TabIndex = 1;
            this.lbJogador.Text = "Seu Nome:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 75);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "X:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(114, 75);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "O:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 36);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Empate:";
            // 
            // txtJogador1
            // 
            this.txtJogador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJogador1.Location = new System.Drawing.Point(117, 29);
            this.txtJogador1.Margin = new System.Windows.Forms.Padding(4);
            this.txtJogador1.MaxLength = 15;
            this.txtJogador1.Name = "txtJogador1";
            this.txtJogador1.Size = new System.Drawing.Size(193, 26);
            this.txtJogador1.TabIndex = 0;
            this.txtJogador1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbO
            // 
            this.lbO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbO.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbO.ForeColor = System.Drawing.Color.Green;
            this.lbO.Location = new System.Drawing.Point(149, 70);
            this.lbO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbO.Name = "lbO";
            this.lbO.Size = new System.Drawing.Size(38, 27);
            this.lbO.TabIndex = 5;
            this.lbO.Text = "0";
            this.lbO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbEmpate
            // 
            this.lbEmpate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbEmpate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmpate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbEmpate.Location = new System.Drawing.Point(90, 31);
            this.lbEmpate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbEmpate.Name = "lbEmpate";
            this.lbEmpate.Size = new System.Drawing.Size(38, 27);
            this.lbEmpate.TabIndex = 5;
            this.lbEmpate.Text = "0";
            this.lbEmpate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbX
            // 
            this.lbX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbX.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbX.ForeColor = System.Drawing.Color.Green;
            this.lbX.Location = new System.Drawing.Point(46, 70);
            this.lbX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbX.Name = "lbX";
            this.lbX.Size = new System.Drawing.Size(38, 27);
            this.lbX.TabIndex = 6;
            this.lbX.Text = "0";
            this.lbX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // blBotaoFechar
            // 
            this.blBotaoFechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.blBotaoFechar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.blBotaoFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.blBotaoFechar.Font = new System.Drawing.Font("MV Boli", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blBotaoFechar.ForeColor = System.Drawing.Color.Linen;
            this.blBotaoFechar.Location = new System.Drawing.Point(515, 1);
            this.blBotaoFechar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.blBotaoFechar.Name = "blBotaoFechar";
            this.blBotaoFechar.Size = new System.Drawing.Size(35, 33);
            this.blBotaoFechar.TabIndex = 7;
            this.blBotaoFechar.Tag = "Fechar jogo";
            this.blBotaoFechar.Text = "X";
            this.blBotaoFechar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.blBotaoFechar.Click += new System.EventHandler(this.blBotaoFechar_Click);
            // 
            // btIniciar
            // 
            this.btIniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btIniciar.Location = new System.Drawing.Point(420, 142);
            this.btIniciar.Name = "btIniciar";
            this.btIniciar.Size = new System.Drawing.Size(116, 84);
            this.btIniciar.TabIndex = 10;
            this.btIniciar.Text = "INICIAR";
            this.btIniciar.UseVisualStyleBackColor = true;
            this.btIniciar.Click += new System.EventHandler(this.btIniciar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("NSimSun", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(292, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Vez de jogar »";
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.moveJ);
            // 
            // vezJogarXO
            // 
            this.vezJogarXO.BackColor = System.Drawing.Color.DarkGray;
            this.vezJogarXO.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.vezJogarXO.Image = global::JogoVelha.Properties.Resources.pv_X;
            this.vezJogarXO.Location = new System.Drawing.Point(488, 314);
            this.vezJogarXO.Margin = new System.Windows.Forms.Padding(4);
            this.vezJogarXO.Name = "vezJogarXO";
            this.vezJogarXO.Size = new System.Drawing.Size(35, 35);
            this.vezJogarXO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.vezJogarXO.TabIndex = 12;
            this.vezJogarXO.TabStop = false;
            this.vezJogarXO.MouseDown += new System.Windows.Forms.MouseEventHandler(this.moveJ);
            // 
            // pc7
            // 
            this.pc7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(215)))), ((int)(((byte)(216)))));
            this.pc7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pc7.Location = new System.Drawing.Point(114, 245);
            this.pc7.Margin = new System.Windows.Forms.Padding(4);
            this.pc7.Name = "pc7";
            this.pc7.Size = new System.Drawing.Size(62, 58);
            this.pc7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pc7.TabIndex = 8;
            this.pc7.TabStop = false;
            // 
            // pc8
            // 
            this.pc8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(215)))), ((int)(((byte)(216)))));
            this.pc8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pc8.Location = new System.Drawing.Point(205, 222);
            this.pc8.Margin = new System.Windows.Forms.Padding(4);
            this.pc8.Name = "pc8";
            this.pc8.Size = new System.Drawing.Size(62, 58);
            this.pc8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pc8.TabIndex = 7;
            this.pc8.TabStop = false;
            // 
            // pc1
            // 
            this.pc1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(215)))), ((int)(((byte)(216)))));
            this.pc1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pc1.Location = new System.Drawing.Point(58, 90);
            this.pc1.Margin = new System.Windows.Forms.Padding(4);
            this.pc1.Name = "pc1";
            this.pc1.Size = new System.Drawing.Size(62, 58);
            this.pc1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pc1.TabIndex = 1;
            this.pc1.TabStop = false;
            // 
            // pc9
            // 
            this.pc9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(215)))), ((int)(((byte)(216)))));
            this.pc9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pc9.Location = new System.Drawing.Point(297, 199);
            this.pc9.Margin = new System.Windows.Forms.Padding(4);
            this.pc9.Name = "pc9";
            this.pc9.Size = new System.Drawing.Size(62, 58);
            this.pc9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pc9.TabIndex = 6;
            this.pc9.TabStop = false;
            // 
            // pc2
            // 
            this.pc2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(215)))), ((int)(((byte)(216)))));
            this.pc2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pc2.Location = new System.Drawing.Point(148, 67);
            this.pc2.Margin = new System.Windows.Forms.Padding(4);
            this.pc2.Name = "pc2";
            this.pc2.Size = new System.Drawing.Size(62, 58);
            this.pc2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pc2.TabIndex = 1;
            this.pc2.TabStop = false;
            // 
            // pc6
            // 
            this.pc6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(215)))), ((int)(((byte)(216)))));
            this.pc6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pc6.Location = new System.Drawing.Point(268, 122);
            this.pc6.Margin = new System.Windows.Forms.Padding(4);
            this.pc6.Name = "pc6";
            this.pc6.Size = new System.Drawing.Size(62, 58);
            this.pc6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pc6.TabIndex = 5;
            this.pc6.TabStop = false;
            // 
            // pc3
            // 
            this.pc3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(215)))), ((int)(((byte)(216)))));
            this.pc3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pc3.Location = new System.Drawing.Point(238, 46);
            this.pc3.Margin = new System.Windows.Forms.Padding(4);
            this.pc3.Name = "pc3";
            this.pc3.Size = new System.Drawing.Size(62, 58);
            this.pc3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pc3.TabIndex = 2;
            this.pc3.TabStop = false;
            // 
            // pc5
            // 
            this.pc5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(215)))), ((int)(((byte)(216)))));
            this.pc5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pc5.Location = new System.Drawing.Point(178, 144);
            this.pc5.Margin = new System.Windows.Forms.Padding(4);
            this.pc5.Name = "pc5";
            this.pc5.Size = new System.Drawing.Size(62, 58);
            this.pc5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pc5.TabIndex = 4;
            this.pc5.TabStop = false;
            // 
            // pc4
            // 
            this.pc4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(215)))), ((int)(((byte)(216)))));
            this.pc4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pc4.Location = new System.Drawing.Point(86, 168);
            this.pc4.Margin = new System.Windows.Forms.Padding(4);
            this.pc4.Name = "pc4";
            this.pc4.Size = new System.Drawing.Size(62, 58);
            this.pc4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pc4.TabIndex = 3;
            this.pc4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-10, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(446, 360);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.moveJ);
            // 
            // Velha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 487);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.painelBorda);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Velha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogo da Velha";
            this.Load += new System.EventHandler(this.Velha_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.painelBorda.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.gbOpcoes.ResumeLayout(false);
            this.gbOpcoes.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vezJogarXO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pc1;
        private System.Windows.Forms.PictureBox pc2;
        private System.Windows.Forms.PictureBox pc3;
        private System.Windows.Forms.PictureBox pc4;
        private System.Windows.Forms.PictureBox pc5;
        private System.Windows.Forms.PictureBox pc6;
        private System.Windows.Forms.PictureBox pc9;
        private System.Windows.Forms.PictureBox pc8;
        private System.Windows.Forms.PictureBox pc7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel painelBorda;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox gbOpcoes;
        private System.Windows.Forms.RadioButton rbPessoa;
        private System.Windows.Forms.RadioButton rbComputador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbJogador;
        private System.Windows.Forms.Label lbComputador;
        private System.Windows.Forms.TextBox txtJogador2;
        private System.Windows.Forms.Label lbX;
        private System.Windows.Forms.Label lbEmpate;
        private System.Windows.Forms.Label lbO;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtJogador1;
        private System.Windows.Forms.Label blBotaoFechar;
        private System.Windows.Forms.Button btIniciar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox vezJogarXO;
    }
}

