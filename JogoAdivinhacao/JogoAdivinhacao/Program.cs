using System;

class Program
{
    static void Main(string[] args)
    {
        JogoAdivinhacao jogo = new JogoAdivinhacao();

        Console.WriteLine("Bem-vindo ao jogo de adivinhação!");
        Console.WriteLine("Você tem 10 chances para adivinhar um número entre 0 e 100.");

        while (jogo.GetChancesRestantes() > 0)
        {
            Console.Write($"\nTentativa {11 - jogo.GetChancesRestantes()}/10 - Digite sua resposta: ");
            if (int.TryParse(Console.ReadLine(), out int tentativa))
            {
                if (jogo.Tentativa(tentativa))
                {
                    return;
                }
            }
            else
            {
                Console.WriteLine("Por favor, insira um número inteiro válido.");
            }
        }

        Console.WriteLine("\nVocê esgotou todas as suas chances. O número correto era: " + jogo.GetNumeroAleatorio());
    }
}
