using System;

namespace Projeto
{
    public class Calculadora
    {
        // Soma(double n1, double n2)
        public double Soma(double n1, double n2)
        {
            return n1 + n2;
        }

        public double Soma(params double[] numeros)
        {
            double resultado = 0.0;
            foreach (double numero in numeros)
            {
                resultado += numero;
            }
            return resultado;
        }

        public double Subtracao(double n1, double n2)
        {
            return n1 - n2;
        }

        public double Multiplicacao(double n1, double n2)
        {
            return n1 * n2;
        }

        public double Divisao(double n1, double n2)
        {
            double resultado = 0D;

            if (n2 != 0)
            {
                resultado = n1 / n2;
            }
            else
            {
                Console.Write($"Não é possivel efetuar divisão por 0");
                return n1;
            }

            return resultado;
        }

    }
}
