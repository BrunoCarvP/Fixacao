namespace CalculaDesconto
{
    public class CalculadoraDesconto
    {
        public double CalcularDesconto(double valorAtual, double percentualDesconto)
        {
            double valorDesconto = valorAtual * (percentualDesconto / 100);
            double valorFinal = valorAtual - valorDesconto;
            return valorFinal;
        }
    }
}
