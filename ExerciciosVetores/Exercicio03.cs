using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosVetores
{
    internal class Exercicio03
    {
        public void Executar()
        {
            string[] nomes = new string[7];
            double[] precos = new double[7];

            for (var i = 0; i < nomes.Length; i++)
            {
                Console.Write("Digite o nome do [" + (i + 1) + "] Produto: ");
                nomes[i] = Console.ReadLine();

                Console.Write("Digite o preco do [" + (i + 1) + "] Produto: ");
                precos[i] = Convert.ToDouble(Console.ReadLine());
            }

            for (var j = 0; j < nomes.Length; j++)
            {
                Console.WriteLine("Nome do [" + (j + 1) + "] Produto: " + nomes[j] + " | Preco: " + precos[j]);
            }
        }
    }
}
