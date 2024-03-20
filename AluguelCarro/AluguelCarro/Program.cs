using System;

namespace AluguelCarro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o total de dias alugados:");

            string entradaDias = Console.ReadLine();

            Console.WriteLine("Digite a quilometragem inicial:");
 
            string entradaKmInicial = Console.ReadLine();

            Console.WriteLine("Digite a quilometragem final:");

            string entradaKmFinal = Console.ReadLine();

            if (int.TryParse(entradaDias, out int totalDias) && double.TryParse(entradaKmInicial, out double kmInicial) && double.TryParse(entradaKmFinal, out double kmFinal))
            {
                CalculadoraAluguel calculadora = new CalculadoraAluguel();

                double valorTotal = calculadora.CalcularValorTotal(totalDias, kmInicial, kmFinal);

                Console.WriteLine("O valor total a ser pago pelo aluguel é: R${0:0.00}", valorTotal);
            }
            else
            {
                Console.WriteLine("Valores inválidos. Certifique-se de inserir números válidos.");
            }
        }
    }
}
