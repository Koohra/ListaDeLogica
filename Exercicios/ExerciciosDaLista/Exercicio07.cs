using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.ExerciciosDaLista
{
    internal class Exercicio07
    {
        public static void ConverterParaDolar()
        {
            Console.WriteLine("Digite o valor em reais:");
            double valorReais = double.Parse(Console.ReadLine()!);

            Console.WriteLine("Digite a cotação do dólar:");
            double cotacaoDolar = double.Parse(Console.ReadLine()!);

            double valorDolares = ValorEmDolares(valorReais, cotacaoDolar);

            Console.WriteLine($"O valor correspondente em dólares é: {valorDolares:F2}");
        }

        public static double ValorEmDolares(double valorReais, double cotacaoDolar)
        {
            return valorReais / cotacaoDolar;
        }
    }
}
