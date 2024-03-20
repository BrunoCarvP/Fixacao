using System;

public class MultiplosDeTres
{
    public static void ImprimirMultiplosDeTres()
    {
        Console.WriteLine("Múltiplos de 3 entre 0 e 100:");
        for (int i = 0; i <= 100; i++)
        {
            if (i % 3 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}
