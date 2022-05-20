using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosVetores
{
    internal class Exercicio02
    {
        public void Executar()
        {
            string[] nomes = new string [10];

            for(var i =0;i<nomes.Length;i++)
            {
                Console.Write("Digite o [" + (i + 1 )+"] nomes: ");
                nomes[i] = Console.ReadLine();
            }

            for (var j=0;j<nomes.Length;j++)
            {
                Console.WriteLine("["+(j + 1) + "] nome: " + nomes[j]);
            }

        }
    }
}
