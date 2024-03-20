using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o seu peso (em kg):");
        double peso = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a sua altura (em metros):");
        double altura = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o seu gênero (M/F):");
        string genero = Console.ReadLine().ToUpper();

        while (genero != "M" && genero != "F")
        {
            Console.WriteLine("Gênero inválido. Digite M para masculino ou F para feminino:");
            genero = Console.ReadLine().ToUpper();
        }

        CalculadoraIMC calculadora = new CalculadoraIMC(peso, altura, genero);

        Console.WriteLine("Peso: " + peso.ToString("F2") + " kg");
        Console.WriteLine("Altura: " + altura.ToString("F2") + " m");
        Console.WriteLine("Gênero: " + genero);
        Console.WriteLine("IMC: " + calculadora.CalcularIMC().ToString("F2"));
        Console.WriteLine("Classificação: " + calculadora.ObterClassificacaoIMC());
    }
}
