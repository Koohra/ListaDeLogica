using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.ExerciciosDaLista
{
    internal class Exercicio08
    {
        public static void VerificarSenha()
        {
            Console.WriteLine("Digite a senha desejada:");
            string senha = Console.ReadLine();

            bool senhaValida = SenhaAtendeCriterios(senha);

            if (senhaValida)
            {
                Console.WriteLine("Senha válida!");
            }
            else
            {
                Console.WriteLine("Senha inválida. A senha deve conter no mínimo 8 caracteres, pelo menos uma letra maiúscula, uma letra minúscula e um número.");
            }
        }

        public static bool SenhaAtendeCriterios(string senha)
        {
            bool temTamanhoMinimo = senha.Length >= 8;
            bool temLetraMaiuscula = false;
            bool temLetraMinuscula = false;
            bool temNumero = false;

            foreach (char caractere in senha)
            {
                if (char.IsUpper(caractere))
                {
                    temLetraMaiuscula = true;
                }
                else if (char.IsLower(caractere))
                {
                    temLetraMinuscula = true;
                }
                else if (char.IsDigit(caractere))
                {
                    temNumero = true;
                }
            }

            return temTamanhoMinimo && temLetraMaiuscula && temLetraMinuscula && temNumero;
        }
    }
}
