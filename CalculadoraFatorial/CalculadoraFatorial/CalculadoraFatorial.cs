using System;

public class CalculadoraFatorial
{
    public static int CalcularFatorial(int numero)
    {
        if (numero == 0 || numero == 1)
        {
            return 1;
        }
        int resultado = 1;
        for (int i = 2; i <= numero; i++)
        {
            resultado *= i;
        }
        return resultado;
    }
}
