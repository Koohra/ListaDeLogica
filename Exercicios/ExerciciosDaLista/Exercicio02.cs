using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.ExerciciosDaLista
{
    internal class Exercicio02
    {
        public static void VerificarNumeroPrimo()
        {
            Console.WriteLine("Digite um número para verificar se é primo:");

            int numero = int.Parse(Console.ReadLine()!);

            bool ehPrimo = EhNumeroPrimo(numero);

            if (ehPrimo)
            {
                Console.WriteLine($"{numero} é um número primo.");
            }
            else
            {
                Console.WriteLine($"{numero} não é um número primo.");
            }
        }

        public static bool EhNumeroPrimo(int numero)
        {
            if (numero <= 1)
            {
                return false;
            }

            if (numero == 2 || numero == 3)
            {
                return true;
            }

            if (numero % 2 == 0)
            {
                return false;
            }

            int divisor = 3;

            while (divisor <= Math.Sqrt(numero))
            {
                if (numero % divisor == 0)
                {
                    return false;
                }

                divisor += 2;
            }

            return true;
        }
    }
}
