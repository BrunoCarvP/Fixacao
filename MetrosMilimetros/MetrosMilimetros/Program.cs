using System;

namespace MetrosMilimetros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor em metros:");

            string entrada = Console.ReadLine();

            if (double.TryParse(entrada, out double metros))
            {
                ConversorMetrosMilimetros conversor = new ConversorMetrosMilimetros();

                double milimetros = conversor.ConverterParaMilimetros(metros);

                Console.WriteLine("{0} metros equivalem a {1} milímetros.", metros, milimetros);
            }
            else
            {
                Console.WriteLine("Valor inválido. Certifique-se de inserir um número válido.");
            }
        }
    }
}
