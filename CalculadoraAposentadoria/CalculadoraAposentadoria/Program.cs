using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Informe sua idade atual: ");
        int idadeAtual = int.Parse(Console.ReadLine());

        Console.Write("Com quantos anos pretende se aposentar: ");
        int idadeAposentadoria = int.Parse(Console.ReadLine());

        Console.Write("Informe o valor que pretende guardar mensalmente para aposentadoria: R$ ");
        double valorMensal = double.Parse(Console.ReadLine());

        Console.Write("Informe a taxa de rendimento mensal da aplicação (%): ");
        double taxaRendimentoMensal = double.Parse(Console.ReadLine());

        double montanteAcumulado = CalculadoraAposentadoria.CalcularMontanteAcumulado(valorMensal, taxaRendimentoMensal, idadeAtual, idadeAposentadoria);
        double rendaMensal = CalculadoraAposentadoria.CalcularRendaMensal(montanteAcumulado, taxaRendimentoMensal, idadeAposentadoria);

        Console.WriteLine($"O montante acumulado no período é: R$ {montanteAcumulado:N2}");
        Console.WriteLine($"Mantendo-se o valor na mesma aplicação, a sua renda mensal será: R$ {rendaMensal:N2}");
    }
}