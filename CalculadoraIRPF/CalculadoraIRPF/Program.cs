using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Informe sua renda: ");
        double renda = double.Parse(Console.ReadLine());

        Console.Write("Informe quantos dependentes possui: ");
        int dependentes = int.Parse(Console.ReadLine());

        double irpf = CalculadoraIRPF.CalcularIRPF(renda, dependentes);

        Console.WriteLine($"O valor de IRPF que será deduzido é: {irpf:C}");
    }
}
