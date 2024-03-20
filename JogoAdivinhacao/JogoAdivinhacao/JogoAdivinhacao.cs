using System;

public class JogoAdivinhacao
{
    private int numeroAleatorio;
    private int chances;

    public JogoAdivinhacao()
    {
        Random random = new Random();
        numeroAleatorio = random.Next(0, 101);
        chances = 10;
    }

    public bool Tentativa(int tentativa)
    {
        if (tentativa < numeroAleatorio)
        {
            Console.WriteLine("O número a ser adivinhado é maior.");
        }
        else if (tentativa > numeroAleatorio)
        {
            Console.WriteLine("O número a ser adivinhado é menor.");
        }
        else
        {
            Console.WriteLine("Parabéns! Você adivinhou o número corretamente!");
            return true;
        }
        chances--;
        return false;
    }

    public int GetChancesRestantes()
    {
        return chances;
    }

    public int GetNumeroAleatorio()
    {
        return numeroAleatorio;
    }
}
