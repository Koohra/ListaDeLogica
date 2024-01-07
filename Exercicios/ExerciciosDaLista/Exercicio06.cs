using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.ExerciciosDaLista
{
    internal class Exercicio06
    {
        public static void CalcularRaizQuadrada()
        {
            Console.WriteLine("Digite um número para calcular a raiz quadrada:");
            double numero = double.Parse(Console.ReadLine()!);

            if (numero < 0)
            {
                Console.WriteLine("Não é possível calcular a raiz quadrada de um número negativo.");
                return;
            }

            double raiz = MetodoParaCalcularARaiz(numero);
            Console.WriteLine($"A raiz quadrada de {numero} é aproximadamente: {raiz:F4}");
        }

        public static double MetodoParaCalcularARaiz(double numero)
        {
            if (numero == 0 || numero == 1)
            {
                return numero;
            }

            double precisao = 0.0001;
            double estimativa = numero / 2;

            double diferenca = numero - (estimativa * estimativa);

            while (diferenca > precisao || diferenca < -precisao)
            {
                estimativa = (estimativa + (numero / estimativa)) / 2;
                diferenca = numero - (estimativa * estimativa);
            }

            return estimativa;
        }
    }
}
