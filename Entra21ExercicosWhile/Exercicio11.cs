using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21ExercicosWhile
{
    internal class Exercicio11
    {
        public void Executar()
        {

            int opcaoDesejada = 0;
            while (opcaoDesejada != 5) 
            {

                Console.Write("Digite o primeiro número: ");
                double primeiroNumero = Convert.ToDouble(Console.ReadLine());
                Console.Write("Digite o segundo numero: ");
                double segundoNumero = Convert.ToDouble(Console.ReadLine());


                Console.WriteLine(" 1 - Somar");
                Console.WriteLine("2 - Subtrair");
                Console.WriteLine("3 - Multiplicar");
                Console.WriteLine("4 - Dividir");
                Console.WriteLine("5 - Sair");
                opcaoDesejada = Convert.ToInt32(Console.ReadLine());


                if (opcaoDesejada == 1)
                {
                    Console.WriteLine("Soma dos valores: " + (primeiroNumero + segundoNumero));
                }
                else if (opcaoDesejada == 2)
                {
                    Console.WriteLine("Subtração do valores: " + (primeiroNumero - segundoNumero))
    ;
                }
                else if (opcaoDesejada == 3)
                {
                    Console.WriteLine("Multiplicação do valores: " + (primeiroNumero * segundoNumero));
                }
                else if (opcaoDesejada == 4)
                {
                    Console.WriteLine("Divisão do valores: " + (primeiroNumero / segundoNumero));
                }
                else if (opcaoDesejada >5 && opcaoDesejada<1)
                {
                    Console.WriteLine("opção inválida! ");
                }
                Console.WriteLine("-----------------------");
            }
        }
    }
}
