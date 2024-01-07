using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.ExerciciosDaLista
{
    internal class Exercicio04
    {
        public static void OrdenarArray()
        {
            Console.WriteLine("Digite o tamanho do array:");
            int tamanho = int.Parse(Console.ReadLine()!);

            int[] array = new int[tamanho];

            Console.WriteLine($"Digite {tamanho} números para preencher o array:");

            for (int i = 0; i < tamanho; i++)
            {
                Console.Write($"Número {i + 1}: ");
                array[i] = int.Parse(Console.ReadLine()!);
            }

            OrdenarArrayCrescente(array);

            Console.WriteLine("\nArray ordenado em ordem crescente:");

            foreach (int num in array)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine();
        }
        public static void OrdenarArrayCrescente(int[] array)
        {
            Array.Sort(array);
        }
    }
}
