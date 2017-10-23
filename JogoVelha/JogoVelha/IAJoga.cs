using System;

namespace JogoVelha
{
    class IAJoga : Tabuleiro
    {
        public int IAChecarVelha(char z)
        {
            //:: 0, 1, 2
            if (LugarTabuleiro[0] == z && LugarTabuleiro[1] == z && LugarTabuleiro[2] == 'V') { return 2; }
            if (LugarTabuleiro[0] == z && LugarTabuleiro[2] == z && LugarTabuleiro[1] == 'V') { return 1; }
            if (LugarTabuleiro[1] == z && LugarTabuleiro[2] == z && LugarTabuleiro[0] == 'V') { return 0; }
            //:: 3, 4, 5
            if (LugarTabuleiro[3] == z && LugarTabuleiro[4] == z && LugarTabuleiro[5] == 'V') { return 5; }
            if (LugarTabuleiro[3] == z && LugarTabuleiro[5] == z && LugarTabuleiro[4] == 'V') { return 4; }
            if (LugarTabuleiro[4] == z && LugarTabuleiro[5] == z && LugarTabuleiro[3] == 'V') { return 3; }
            //:: 6, 7, 8
            if (LugarTabuleiro[6] == z && LugarTabuleiro[7] == z && LugarTabuleiro[8] == 'V') { return 8; }
            if (LugarTabuleiro[6] == z && LugarTabuleiro[8] == z && LugarTabuleiro[7] == 'V') { return 7; }
            if (LugarTabuleiro[7] == z && LugarTabuleiro[8] == z && LugarTabuleiro[6] == 'V') { return 6; }
            //:: 0, 3, 6
            if (LugarTabuleiro[0] == z && LugarTabuleiro[3] == z && LugarTabuleiro[6] == 'V') { return 6; }
            if (LugarTabuleiro[0] == z && LugarTabuleiro[6] == z && LugarTabuleiro[3] == 'V') { return 3; }
            if (LugarTabuleiro[3] == z && LugarTabuleiro[6] == z && LugarTabuleiro[0] == 'V') { return 0; }
            //:: 1, 4, 7
            if (LugarTabuleiro[1] == z && LugarTabuleiro[4] == z && LugarTabuleiro[7] == 'V') { return 7; }
            if (LugarTabuleiro[1] == z && LugarTabuleiro[7] == z && LugarTabuleiro[4] == 'V') { return 4; }
            if (LugarTabuleiro[4] == z && LugarTabuleiro[7] == z && LugarTabuleiro[1] == 'V') { return 1; }
            //:: 2, 5, 8
            if (LugarTabuleiro[2] == z && LugarTabuleiro[5] == z && LugarTabuleiro[8] == 'V') { return 8; }
            if (LugarTabuleiro[2] == z && LugarTabuleiro[8] == z && LugarTabuleiro[5] == 'V') { return 5; }
            if (LugarTabuleiro[5] == z && LugarTabuleiro[8] == z && LugarTabuleiro[2] == 'V') { return 2; }
            //:: 0, 4, 8
            if (LugarTabuleiro[0] == z && LugarTabuleiro[4] == z && LugarTabuleiro[8] == 'V') { return 8; }
            if (LugarTabuleiro[0] == z && LugarTabuleiro[8] == z && LugarTabuleiro[4] == 'V') { return 4; }
            if (LugarTabuleiro[4] == z && LugarTabuleiro[8] == z && LugarTabuleiro[0] == 'V') { return 0; }
            //:: 2, 4, 6
            if (LugarTabuleiro[2] == z && LugarTabuleiro[4] == z && LugarTabuleiro[6] == 'V') { return 6; }
            if (LugarTabuleiro[2] == z && LugarTabuleiro[6] == z && LugarTabuleiro[4] == 'V') { return 4; }
            if (LugarTabuleiro[4] == z && LugarTabuleiro[6] == z && LugarTabuleiro[2] == 'V') { return 2; }
            //:: Se não formou uma trilha
            return -1;
        }

        public int IAaleatorio()
        {
            Random rn = new Random();
            int i = 0;
            do
            {
                int p = rn.Next(0,8);
                if (LugarTabuleiro[p] == 'V') { return p; }
                i++;
            }
            while (i <= 8);
            return -1;
        }
    }
}
