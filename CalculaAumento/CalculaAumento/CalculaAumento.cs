namespace CalculaAumento
{
    public class CalculadoraAumento
    {
        public double CalcularAumento(double valorBase, double taxa)
        {
            return valorBase * (1 + taxa / 100);
        }
    }
}
