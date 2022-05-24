using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosVetores
{
    internal class Exercicio02L02
    {
        public void Executar()
        {
            string[] nomes = new string[5];
            string[] nomes2 = new string[5];

            for (var i = 0;i<nomes.Length;i++)
            {
                Console.Write("Digite um nome: ");
                nomes[i] = Console.ReadLine();
            }

            for(var i = 4;i>=0;i--)
            {
                for (var j = 0; j < nomes2.Length;j++)
                {
                    nomes2[i] = nomes[j];
                }
            }

            for(var i = 0; i<nomes.Length;i++)
            {
                Console.WriteLine("Vetor 1: " + nomes[i]);
            }
            for (var i = 0; i < nomes2.Length; i++)
            {
                Console.WriteLine("Vetor 2: " + nomes2[i]);
            }
        }
    }
}
