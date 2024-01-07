using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.ExerciciosDaLista
{
    internal class Exercicio03
    {
        public static void CalcularFatorial()
        {
            Console.WriteLine("Digite um número inteiro positivo para calcular o fatorial:");
            int numero = int.Parse(Console.ReadLine()!);

            if (numero < 0)
            {
                Console.WriteLine("Por favor, digite um número inteiro positivo.");
                return;
            }

            long resultado = Calcular(numero);
            Console.WriteLine($"O fatorial de {numero} é: {resultado}");
        }

        public static long Calcular(int numero)
        {
            if (numero == 0 || numero == 1)
            {
                return 1;
            }
            else
            {
                long fatorial = 1;
                for (int i = 2; i <= numero; i++)
                {
                    fatorial *= i;
                }
                return fatorial;
            }
        }
    }
}
