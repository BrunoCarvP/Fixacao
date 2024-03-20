using System;

public class CalculadoraIRPF
{
    private static readonly double[] faixas = { 1903.98, 2826.65, 3751.05, 4664.68, double.MaxValue };
    private static readonly double[] aliquotas = { 0.075, 0.15, 0.225, 0.275 };
    private static readonly double[] deducoes = { 142.80, 354.80, 636.13, 869.36 };

    public static double CalcularIRPF(double renda, int dependentes)
    {
        double rendaLiquida = renda - dependentes * 500;
        double imposto = 0;

        for (int i = 0; i < faixas.Length; i++)
        {
            if (rendaLiquida <= faixas[i])
            {
                imposto += rendaLiquida * aliquotas[i] - deducoes[i];
                break;
            }
            else
            {
                imposto += (faixas[i] - (i == 0 ? 0 : faixas[i - 1])) * aliquotas[i] - deducoes[i];
                rendaLiquida -= faixas[i] - (i == 0 ? 0 : faixas[i - 1]);
            }
        }

        return imposto;
    }
}