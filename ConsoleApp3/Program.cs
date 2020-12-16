using System;
using System.Globalization;

namespace Projeto
{  
    class Program
    { 
        public static void Main(String[] args)
        {

            IniciaCalculadora();
            Console.Read();
        }

        public static void EntradaDeDados(out double n1, ref string operacao, string operacaoPlus)
        {
            Console.WriteLine("Insira um numero");
            n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(Menu(operacaoPlus));
            operacao = Console.ReadLine();

        }

        public static string Menu(string operacao)
        {
            return "Escolha uma operação : \n" +
               "+ (soma)\n" +
               "- (subtração) \n" +
               "* (multiplicação) \n" +
               "/ (divisão) \n" +
               operacao;
        }

        public static void IniciaCalculadora()
        {

            Calculadora calculadora = new Calculadora();

            double n1;

            double resultado = 0D;
            string operacao = "";



            EntradaDeDados(out n1, ref operacao, "");
            resultado = n1;
            do
            {
                if (operacao.Trim().Equals("+"))
                {
                    EntradaDeDados(out n1, ref operacao, "= (Resultado)");
                    resultado = calculadora.Soma(resultado, n1);
                   
                } else if (operacao.Trim().Equals("-"))
                {
                    EntradaDeDados(out n1, ref operacao, "= (Resultado)");
                    resultado = calculadora.Subtracao(resultado, n1);
                } else if (operacao.Trim().Equals("*"))
                {
                    EntradaDeDados(out n1, ref operacao, "= (Resultado)");
                    resultado = calculadora.Multiplicacao(resultado, n1);
                } else if (operacao.Trim().Equals("/"))
                {
                    EntradaDeDados(out n1, ref operacao, "= (Resultado)");
                    resultado = calculadora.Divisao(resultado, n1);
                } else
                {
                    Console.WriteLine("Operação Indisponivel");
                }

            } while (!operacao.Equals("="));

            Console.WriteLine(resultado);
        }
    }

}