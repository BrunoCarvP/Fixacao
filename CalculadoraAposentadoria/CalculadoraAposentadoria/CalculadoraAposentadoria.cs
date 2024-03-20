using System;


using System;

public class CalculadoraAposentadoria
{
    public static double CalcularMontanteAcumulado(double valorMensal, double taxaRendimentoMensal, int idadeAtual, int idadeAposentadoria)
    {
        int anosParaAposentadoria = idadeAposentadoria - idadeAtual;
        int mesesParaAposentadoria = anosParaAposentadoria * 12;
        double montanteAcumulado = 0;

        for (int i = 0; i < mesesParaAposentadoria; i++)
        {
            montanteAcumulado += valorMensal;
            montanteAcumulado *= (1 + taxaRendimentoMensal / 100);
        }

        return montanteAcumulado;
    }

    public static double CalcularRendaMensal(double montanteAcumulado, double taxaRendimentoMensal, int idadeAposentadoria)
    {
        int expectativaVida = 85;
        int anosAposentado = expectativaVida - idadeAposentadoria;
        int mesesAposentado = anosAposentado * 12;

        double rendaMensal = montanteAcumulado / mesesAposentado;
        rendaMensal *= (1 + taxaRendimentoMensal / 100); 
        return rendaMensal;
    }
}