using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosVetores
{
    internal class Exercicio07
    {
        public void Executar()
        {
            double[] altura = new double[4];
            var menorAltura = double.MaxValue;

            for (var i = 0; i<altura.Length;i++)
            {
                Console.WriteLine("Digite a altura do " + (i + 1) + "° animal: ");
                altura[i] = Convert.ToDouble(Console.ReadLine());

                 if (altura[i]<menorAltura)
                {
                    menorAltura = altura[i];
                }
            }
            Console.WriteLine("animal com menor altura: " + menorAltura);
        }
    }
}
