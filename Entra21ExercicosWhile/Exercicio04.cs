using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21ExercicosWhile
{
    internal class Exercicio04
    {
        public void Executar()
        {
            double peso = 1;
            int quantidadePessoas = 0;
            while ((peso < 300) && (peso > 0))
            {
                Console.Write("Digite seu peso: ");
                peso = Convert.ToDouble(Console.ReadLine());

                quantidadePessoas = quantidadePessoas + 1;

            }
            Console.WriteLine("quantidade Pessoas de pessoas que digitaream o peso: " + quantidadePessoas);
        }
    }
}
