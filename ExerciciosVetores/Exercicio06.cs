using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosVetores
{
    internal class Exercicio06
    {
        public void Executar()
        {
            double[] idades = new double[9];
            double maiorIdade = double.MinValue;

            for (var i = 0;i<idades.Length;i++)
            {
                Console.Write("Digite a [" + (i + 1) + "] idade: ");
                idades[i] = Convert.ToDouble(Console.ReadLine());
            }

            for (var j = 0; j < idades.Length; j++)
            {
                if (idades[j] > maiorIdade)
                {
                    maiorIdade = idades[j];
                }
            }
            Console.WriteLine("Maior idade: " + maiorIdade);
        }
    }
}
