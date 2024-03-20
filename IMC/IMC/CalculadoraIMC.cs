using System;

public class CalculadoraIMC
{
    public double Peso { get; set; }
    public double Altura { get; set; }
    public string Genero { get; set; }

    public CalculadoraIMC(double peso, double altura, string genero)
    {
        Peso = peso;
        Altura = altura;
        Genero = genero;
    }

    public double CalcularIMC()
    {
        return Peso / (Altura * Altura);
    }

    public string ObterClassificacaoIMC()
    {
        double imc = CalcularIMC();

        if (imc < 18.5)
        {
            return "Abaixo do peso";
        }
        else if (imc >= 18.5 && imc < 25)
        {
            return "Peso ideal (parabéns!)";
        }
        else if (imc >= 25 && imc < 30)
        {
            return "Levemente acima do peso";
        }
        else if (imc >= 30 && imc < 35)
        {
            return "Obesidade grau I";
        }
        else if (imc >= 35 && imc < 40)
        {
            return "Obesidade grau II (severa)";
        }

        return "Obesidade grau III (mórbida)";
    }
}
