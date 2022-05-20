using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosVetores
{
    internal class Exercicio05
    {
        public void Executar()
        {
            double[] pesos = new double[5];
            double somaPesos = 0;

            for (var i = 0;i<pesos.Length;i++)
            {
                Console.Write("Digite o [" + (i + 1) + "] peso: ");
                pesos[i] = Convert.ToDouble(Console.ReadLine());
                somaPesos = somaPesos + pesos[i];
            }
            Console.WriteLine("Soma total dos Pesos: " + somaPesos);
            Console.WriteLine("Média do Pesos: " + (somaPesos / pesos.Length));
        }
    }
}
