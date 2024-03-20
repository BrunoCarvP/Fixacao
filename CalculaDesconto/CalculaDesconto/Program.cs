using System;

namespace CalculaDesconto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor atual da mercadoria:");

            string entradaValor = Console.ReadLine();

            Console.WriteLine("Digite o percentual de desconto (%):");

            string entradaDesconto = Console.ReadLine();

            if (double.TryParse(entradaValor, out double valorAtual) && double.TryParse(entradaDesconto, out double percentualDesconto))
            {
                CalculadoraDesconto calculadora = new CalculadoraDesconto();

                double valorFinal = calculadora.CalcularDesconto(valorAtual, percentualDesconto);
                double valorDesconto = valorAtual - valorFinal;

                Console.WriteLine("Valor atual da mercadoria: {0}", valorAtual);
                Console.WriteLine("Percentual de desconto: {0}%", percentualDesconto);
                Console.WriteLine("Valor do desconto: {0}", valorDesconto);
                Console.WriteLine("Valor final da mercadoria: {0}", valorFinal);
            }
            else
            {
                Console.WriteLine("Valores inválidos. Certifique-se de inserir números válidos.");
            }
        }
    }
}
