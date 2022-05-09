using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21ExercicosWhile
{
    internal class Exercicio10
    {
        public void Executar()
        {
            Console.Write("Digite um número: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            int numeroInicial = numero;
            int antecessorSucessor = numero - 52;
            int paridade = numero % 2;

            Console.WriteLine("----------------50 Antecessores Pares----------------");

            while (numero != antecessorSucessor)
            {

                if (paridade == 0)
                {
                    Console.WriteLine(numero + ": PAR");
                }
                numero = numero - 2;

            }
            
       
            Console.WriteLine("----------------50 Sucessores ímpares----------------");

            numero = numeroInicial;
            antecessorSucessor = numeroInicial + 51;

            while (numero != antecessorSucessor)
            {
                paridade = numero % 2;
                if (paridade == 1)
                {
                    Console.WriteLine(numero + ": ÍMPAR");
                }
                numero = numero + 1;
                
            }
        }
    }
}