using Exercicios.ExerciciosDaLista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Menu
{
    internal class Interface
    {
        public static void MostrarMenu()
        {
            bool sair = false;

            do
            {
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1. Exercicio 1 - Converter temperatura");
                Console.WriteLine("2. Exercicio 2 - Verificar número primo");
                Console.WriteLine("3. Exercicio 3 - Calcular fatorial");
                Console.WriteLine("4. Exercicio 4 - Ordenar array");
                Console.WriteLine("5. Exercicio 5 - Verificar palíndromo");
                Console.WriteLine("6. Exercicio 6 - Calcular raiz quadrada");
                Console.WriteLine("7. Exercicio 7 - Converter valor para dólar");
                Console.WriteLine("8. Exercicio 8 - Validar senha");
                Console.WriteLine("9. Exercicio 9 - Validar CPF");
                Console.WriteLine("10. Exercicio 10 - Analisar texto");
                Console.WriteLine("0. Sair");

                int opcao = int.Parse(Console.ReadLine()!);

                switch (opcao)
                {
                    case 1:
                        Exercicio01.ExecutarConversao();
                        Console.WriteLine($"\nPrecione [ENTER] para voltar");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 2:
                        Exercicio02.VerificarNumeroPrimo();
                        Console.WriteLine($"\nPrecione [ENTER] para voltar");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 3:
                        Exercicio03.CalcularFatorial();
                        Console.WriteLine($"\nPrecione [ENTER] para voltar");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 4:
                        Exercicio04.OrdenarArray();
                        Console.WriteLine($"\nPrecione [ENTER] para voltar");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 5:
                        Exercicio05.VerificarPalindromo();
                        Console.WriteLine($"\nPrecione [ENTER] para voltar");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 6:
                        Exercicio06.CalcularRaizQuadrada();
                        Console.WriteLine($"\nPrecione [ENTER] para voltar");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 7:
                        Exercicio07.ConverterParaDolar();
                        Console.WriteLine($"\nPrecione [ENTER] para voltar");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 8:
                        Exercicio08.VerificarSenha();
                        Console.WriteLine($"\nPrecione [ENTER] para voltar");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 9:
                        Exercicio09.ValidarCPF();
                        Console.WriteLine($"\nPrecione [ENTER] para voltar");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 10:
                        Exercicio10.AnalisarTexto();
                        Console.WriteLine($"\nPrecione [ENTER] para voltar");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 0:
                        sair = true;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }

            } while (!sair);
        }
    }
}
