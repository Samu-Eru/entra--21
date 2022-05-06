using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21ExercicosWhile
{
    internal class Exercicio08
    {
        public void Executar()
        {
            int indice = 0;

            Console.WriteLine("Digite um valor: ");
            int valorDigitado = Convert.ToInt32(Console.ReadLine());

            while (indice<=1000)
            {
                Console.WriteLine(valorDigitado + " X " + indice + " = " + valorDigitado * indice);

                indice = indice + 1;

             
            }
        }
    }
}
