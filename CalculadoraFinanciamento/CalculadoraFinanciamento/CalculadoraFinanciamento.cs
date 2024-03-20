using System;
public class CalculadoraFinanciamento
{
    public static double CalcularTotalPago(double valorVeiculo, int totalParcelas, double taxaMensal)
    {
        double valorTotalPago = valorVeiculo;

        for (int i = 1; i <= totalParcelas; i++)
        {
            valorTotalPago += valorTotalPago * taxaMensal / 100;
        }

        return valorTotalPago;
    }
}
