namespace AluguelCarro
{
    public class CalculadoraAluguel
    {
        private const double ValorDiaria = 95.00;
        private const double ValorPorKm = 0.35;

        public double CalcularValorTotal(int totalDias, double kmInicial, double kmFinal)
        {
            double valorDiarias = totalDias * ValorDiaria;
            double valorKm = (kmFinal - kmInicial) * ValorPorKm;
            return valorDiarias + valorKm;
        }
    }
}
