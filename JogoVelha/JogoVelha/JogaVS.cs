namespace JogoVelha
{
    class JogaVS : Tabuleiro
    {
        //:: Guarda vez de jogada :: jogador 1 sempre será 1° a jogar
        //> vp1 para jogador 1
        //> vp2 para jogador 2
        private static string vezDeJogar = "vp1";
        public string VezDeJogar { get => vezDeJogar; set => vezDeJogar = value; }

        public bool ChecarVelha(char z)
        {
            //:: 0, 1, 2
            if (LugarTabuleiro[0] == z && LugarTabuleiro[1] == z && LugarTabuleiro[2] == z) { return true; }
            //:: 3, 4, 5
            if (LugarTabuleiro[3] == z && LugarTabuleiro[4] == z && LugarTabuleiro[5] == z) { return true; }
            //:: 6, 7, 8
            if (LugarTabuleiro[6] == z && LugarTabuleiro[7] == z && LugarTabuleiro[8] == z) { return true; }
           
            //:: 0, 3, 6
            if (LugarTabuleiro[0] == z && LugarTabuleiro[3] == z && LugarTabuleiro[6] == z) { return true; }
            //:: 1, 4, 7
            if (LugarTabuleiro[1] == z && LugarTabuleiro[4] == z && LugarTabuleiro[7] == z) { return true; }
            //:: 2, 5, 8
            if (LugarTabuleiro[2] == z && LugarTabuleiro[5] == z && LugarTabuleiro[8] == z) { return true; }
           
            //:: 0, 4, 8
            if (LugarTabuleiro[0] == z && LugarTabuleiro[4] == z && LugarTabuleiro[8] == z) { return true; }
            //:: 2, 4, 6
            if (LugarTabuleiro[2] == z && LugarTabuleiro[4] == z && LugarTabuleiro[6] == z) { return true; }

            //:: Se não formou velha
            return false;
        }
    }
}
