namespace JogoVelha
{
    class Tabuleiro
    {
        //:: Guarda as posições do tabuleiro
        //>  O [letra o Maiúscula] para Bolinha
        //>  X para X
        //>  V para Vazio
        private static char[] lugarTabuleiro = { 'V', 'V', 'V', 'V', 'V', 'V', 'V', 'V', 'V' };
        public char[] LugarTabuleiro { get => lugarTabuleiro; set => lugarTabuleiro = value; }

        //:: Verifica se lugar no tabuleiro está vazio
        public int LugarVazio(string lugar)
        {
            switch (lugar)
            {
                case "pc1": if (LugarTabuleiro[0] == 'V') return 0; break;
                case "pc2": if (LugarTabuleiro[1] == 'V') return 1; break;
                case "pc3": if (LugarTabuleiro[2] == 'V') return 2; break;
                case "pc4": if (LugarTabuleiro[3] == 'V') return 3; break;
                case "pc5": if (LugarTabuleiro[4] == 'V') return 4; break;
                case "pc6": if (LugarTabuleiro[5] == 'V') return 5; break;
                case "pc7": if (LugarTabuleiro[6] == 'V') return 6; break;
                case "pc8": if (LugarTabuleiro[7] == 'V') return 7; break;
                case "pc9": if (LugarTabuleiro[8] == 'V') return 8; break;
            }
            //:: Se estiver ocupado
            return -1;
        }

        //:: Reseta o tabuleiro
        public void ReseteTabuleiro()
        {
            for (int i = 0; i<LugarTabuleiro.Length; i++)
            {
                LugarTabuleiro[i] = 'V';
            }
        }

        //:: Realiza contagem para saber se deu velha
        public int Empate()
        {
            int pontos = 0;
            for (int i = 0; i < LugarTabuleiro.Length; i++)
            {
                if(LugarTabuleiro[i] == 'V') { pontos = 0; return -1; }
                pontos++;
            }
            return pontos;
        }
    }
}
