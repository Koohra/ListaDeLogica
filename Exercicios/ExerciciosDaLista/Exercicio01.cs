using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.ExerciciosDaLista
{
    internal class Exercicio01
    {
        public static void ExecutarConversao()
        {
            Console.WriteLine("Escolha a opção de conversão:");
            Console.WriteLine("1. Celsius para Fahrenheit");
            Console.WriteLine("2. Fahrenheit para Celsius");

            int opcao = int.Parse(Console.ReadLine()!);

            double temperatura;
            double resultado;

            if (opcao == 1)
            {
                Console.WriteLine("Digite a temperatura em Celsius:");
                temperatura = double.Parse(Console.ReadLine()!);
                resultado = CelsiusParaFahrenheit(temperatura);
                Console.WriteLine($"O resultado em Fahrenheit é: {resultado:F2}");
            }
            else if (opcao == 2)
            {
                Console.WriteLine("Digite a temperatura em Fahrenheit:");
                temperatura = double.Parse(Console.ReadLine()!);
                resultado = FahrenheitParaCelsius(temperatura);
                Console.WriteLine($"O resultado em Celsius é: {resultado:F2}");
            }
            else
            {
                Console.WriteLine("Opção inválida. Por favor, escolha 1 ou 2.");
            }
        }

        public static double CelsiusParaFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        public static double FahrenheitParaCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
    }

}

