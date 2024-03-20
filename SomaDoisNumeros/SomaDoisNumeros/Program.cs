using System;

namespace SomaDoisNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro número:");
            double numero1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            double numero2 = double.Parse(Console.ReadLine());

            SomaDoisNumeros soma = new SomaDoisNumeros(numero1, numero2);

            double resultado = soma.CalcularSoma();

            Console.WriteLine("A soma dos números é: {0}", resultado);
        }
    }
}
