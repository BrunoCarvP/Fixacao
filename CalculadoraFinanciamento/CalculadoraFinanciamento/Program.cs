using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Informe o valor do veículo: R$ ");
        double valorVeiculo = double.Parse(Console.ReadLine());

        Console.Write("Informe o total de parcelas: ");
        int totalParcelas = int.Parse(Console.ReadLine());

        Console.Write("Informe a taxa mensal de juros (%): ");
        double taxaMensal = double.Parse(Console.ReadLine());

        double totalPago = CalculadoraFinanciamento.CalcularTotalPago(valorVeiculo, totalParcelas, taxaMensal);

        Console.WriteLine($"O valor total pago no veículo considerando todas as parcelas pagas é: R$ {totalPago:F2}");
    }
}
