using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.ExerciciosDaLista
{
    internal class Exercicio05
    {
        public static void VerificarPalindromo()
        {
            Console.WriteLine("Digite uma palavra para verificar se é um palíndromo:");
            string palavra = Console.ReadLine()!.ToLower();

            bool ehPalindromo = EhPalindromo(palavra);

            if (ehPalindromo)
            {
                Console.WriteLine($"A palavra '{palavra}' é um palíndromo.");
            }
            else
            {
                Console.WriteLine($"A palavra '{palavra}' não é um palíndromo.");
            }
        }
        public static bool EhPalindromo(string palavra)
        {
            int comprimento = palavra.Length;

            for (int i = 0; i < comprimento / 2; i++)
            {
                if (palavra[i] != palavra[comprimento - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
