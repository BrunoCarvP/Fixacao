using System;

namespace CalculaAumento
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor base:");

            string entradaValorBase = Console.ReadLine();

            Console.WriteLine("Digite a taxa de aumento (%):");

            string entradaTaxa = Console.ReadLine();

            if (double.TryParse(entradaValorBase, out double valorBase) && double.TryParse(entradaTaxa, out double taxa))
            {
                CalculadoraAumento calculadora = new CalculadoraAumento();

                double resultado = calculadora.CalcularAumento(valorBase, taxa);

                Console.WriteLine("O valor após o aumento é: {0}", resultado);
            }
            else
            {
                Console.WriteLine("Valores inválidos. Certifique-se de inserir números válidos.");
            }
        }
    }
}
