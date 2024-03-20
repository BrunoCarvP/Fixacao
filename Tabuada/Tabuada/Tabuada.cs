using System;

public class Tabuada
{
    public static void GerarTabuada(int numero)
    {
        Console.WriteLine($"Tabuada do {numero}:");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{numero} x {i} = {numero * i}");
        }
        Console.WriteLine();
    }
}
