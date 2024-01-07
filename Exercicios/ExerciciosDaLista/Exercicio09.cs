using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.ExerciciosDaLista
{
    internal class Exercicio09
    {
        public static void ValidarCPF()
        {
            Console.WriteLine("Digite um CPF (apenas números):");
            string cpf = Console.ReadLine()!;

            bool cpfValido = VerificarCPFFormato(cpf) && VerificarCPFDigitoVerificador(cpf);

            if (cpfValido)
            {
                Console.WriteLine("CPF válido!");
            }
            else
            {
                Console.WriteLine("CPF inválido.");
            }
        }

        public static bool VerificarCPFFormato(string cpf)
        {
            if (cpf.Length != 11)
            {
                return false;
            }

            foreach (char c in cpf)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }

            return true;
        }

        public static bool VerificarCPFDigitoVerificador(string cpf)
        {
            int[] multiplicadoresPrimeiroDigito = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicadoresSegundoDigito = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            string cpfSemDigitos = cpf.Substring(0, 9);

            int primeiroDigito = CalcularDigitoVerificador(cpfSemDigitos, multiplicadoresPrimeiroDigito);
            int segundoDigito = CalcularDigitoVerificador(cpfSemDigitos + primeiroDigito, multiplicadoresSegundoDigito);

            return cpf.EndsWith($"{primeiroDigito}{segundoDigito}");
        }

        public static int CalcularDigitoVerificador(string cpfParcial, int[] multiplicadores)
        {
            int total = 0;

            for (int i = 0; i < cpfParcial.Length; i++)
            {
                total += int.Parse(cpfParcial[i].ToString()) * multiplicadores[i];
            }

            int resto = total % 11;
            return (resto < 2) ? 0 : (11 - resto);
        }
    }
}
