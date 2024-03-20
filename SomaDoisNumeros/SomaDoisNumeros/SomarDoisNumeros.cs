using System;

namespace SomaDoisNumeros
{
    public class SomaDoisNumeros
    {
        public double Numero1 { get; set; }
        public double Numero2 { get; set; }

        public SomaDoisNumeros(double numero1, double numero2)
        {
            Numero1 = numero1;
            Numero2 = numero2;
        }

        public double CalcularSoma()
        {
            return Numero1 + Numero2;
        }
    }
}
