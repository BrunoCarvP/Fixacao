using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Fatoriais de 1 até 10:");
        for (int i = 1; i <= 10; i++)
        {
            int fatorial = CalculadoraFatorial.CalcularFatorial(i);
            Console.WriteLine($"Fatorial de {i}: {fatorial}");
        }
    }
}
