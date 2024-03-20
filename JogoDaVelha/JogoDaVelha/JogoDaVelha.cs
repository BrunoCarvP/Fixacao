using System;

public class JogoDaVelha
{
    private char[,] tabuleiro;
    private bool jogadorX;

    public JogoDaVelha()
    {
        tabuleiro = new char[3, 3];
        jogadorX = true;
        InicializarTabuleiro();
    }

    private void InicializarTabuleiro()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                tabuleiro[i, j] = '-';
            }
        }
    }

    public void ImprimirTabuleiro()
    {
        Console.WriteLine("Tabuleiro:");

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(tabuleiro[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    public bool FazerJogada(int linha, int coluna)
    {
        if (linha < 0 || linha >= 3 || coluna < 0 || coluna >= 3 || tabuleiro[linha, coluna] != '-')
        {
            Console.WriteLine("Jogada inválida. Tente novamente.");
            return false;
        }

        tabuleiro[linha, coluna] = jogadorX ? 'X' : 'O';
        jogadorX = !jogadorX;
        return true;
    }

    public bool VerificarVencedor()
    {
        for (int i = 0; i < 3; i++)
        {
            if (tabuleiro[i, 0] != '-' && tabuleiro[i, 0] == tabuleiro[i, 1] && tabuleiro[i, 0] == tabuleiro[i, 2])
            {
                Console.WriteLine($"Jogador {tabuleiro[i, 0]} venceu!");
                return true;
            }

            if (tabuleiro[0, i] != '-' && tabuleiro[0, i] == tabuleiro[1, i] && tabuleiro[0, i] == tabuleiro[2, i])
            {
                Console.WriteLine($"Jogador {tabuleiro[0, i]} venceu!");
                return true;
            }
        }

        if (tabuleiro[0, 0] != '-' && tabuleiro[0, 0] == tabuleiro[1, 1] && tabuleiro[0, 0] == tabuleiro[2, 2])
        {
            Console.WriteLine($"Jogador {tabuleiro[0, 0]} venceu!");
            return true;
        }

        if (tabuleiro[0, 2] != '-' && tabuleiro[0, 2] == tabuleiro[1, 1] && tabuleiro[0, 2] == tabuleiro[2, 0])
        {
            Console.WriteLine($"Jogador {tabuleiro[0, 2]} venceu!");
            return true;
        }

        bool jogoAcabou = true;
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (tabuleiro[i, j] == '-')
                {
                    jogoAcabou = false;
                    break;
                }
            }
            if (!jogoAcabou) break;
        }

        if (jogoAcabou)
        {
            Console.WriteLine("Jogo acabou sem vencedores.");
            return true;
        }

        return false;
    }

    public bool JogadorAtual()
    {
        return jogadorX;
    }
}
