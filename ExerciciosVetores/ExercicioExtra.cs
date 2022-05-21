using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosVetores
{
    internal class ExercicioExtra
    {
        public void Executar()
        {
            int[] numerosInteiros = new int[10];
            int[] numerosPares = new int[5];
            int[] numerosImpares = new int[5];
            int i = 1;

            for ( i = 0; i < numerosInteiros.Length; i++) ;
            {
                var numeroPositivo = false;
                while (numeroPositivo == false)
                {
                    Console.WriteLine("Digite numeros inteiros e positivos: ");
                    numerosInteiros[i] = Convert.ToInt32(Console.ReadLine());

                    if (numerosInteiros[i] < 1)
                    {
                        Console.WriteLine("negativo inválido!!");
                    }
                    else
                    {
                        numeroPositivo = true;
                    }
                }

            }

            for (int j = 0;j<numerosInteiros.Length;j++)
            {
                int paridade = (numerosInteiros[j] % 2 );

                if (paridade == 0)
                {
                    numerosPares[j] = numerosInteiros[j];
                }
                else
                {
                    numerosImpares[j] = numerosInteiros[j];
                }
            }

            for(int k=0;k<numerosInteiros.Length;k++)
            {
                if()
            }
        }
    }
}
