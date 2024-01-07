using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.ExerciciosDaLista
{
    internal class Exercicio10
    {
        public static void AnalisarTexto()
        {
            Console.WriteLine("Digite um texto:");
            string texto = Console.ReadLine()!;

            string[] palavras = texto.Split(new char[] { ' ', '.', ',', ';', ':', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> frequenciaPalavras = CalcularFrequenciaPalavras(palavras);

            Console.WriteLine("\nFrequência das palavras no texto:");

            foreach (var item in frequenciaPalavras)
            {
                Console.WriteLine($"'{item.Key}' aparece {item.Value} vezes");
            }
        }

        public static Dictionary<string, int> CalcularFrequenciaPalavras(string[] palavras)
        {
            Dictionary<string, int> frequencia = new Dictionary<string, int>();

            foreach (string palavra in palavras)
            {
                string palavraLowerCase = palavra.ToLower();

                if (frequencia.ContainsKey(palavraLowerCase))
                {
                    frequencia[palavraLowerCase]++;
                }
                else
                {
                    frequencia[palavraLowerCase] = 1;
                }
            }

            return frequencia;
        }
    }
}
