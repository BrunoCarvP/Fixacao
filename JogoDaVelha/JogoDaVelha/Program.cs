using System;

class Program
{
    static void Main(string[] args)
    {
        JogoDaVelha jogo = new JogoDaVelha();
        bool jogoAcabou = false;

        Console.WriteLine("Bem-vindo ao Jogo da Velha!");

        while (!jogoAcabou)
        {
            jogo.ImprimirTabuleiro();

            char jogadorAtual = jogo.JogadorAtual() ? 'X' : 'O';
            Console.Write($"Jogador {jogadorAtual}, informe a linha (0-2): ");
            int linha = int.Parse(Console.ReadLine());
            Console.Write($"Jogador {jogadorAtual}, informe a coluna (0-2): ");
            int coluna = int.Parse(Console.ReadLine());

            if (jogo.FazerJogada(linha, coluna))
            {
                jogoAcabou = jogo.VerificarVencedor();
            }
        }
    }
}
