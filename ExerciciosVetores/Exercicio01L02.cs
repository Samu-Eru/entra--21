using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosVetores
{
    internal class Exercicio01L02
    {
        public void Executar()
        {
            int[] numerosPares = new int[10];
            int numerosDigitados = 0;

            for (int i = 0; i < numerosPares.Length; i++)
            {

                var paridade = false;
                while (paridade == false)
                {
                    Console.Write("Digite numeros: ");
                    numerosDigitados = Convert.ToInt32(Console.ReadLine());

                    if ((numerosDigitados % 2) == 0)
                    {
                        numerosPares[i] = numerosDigitados;
                        paridade = true;
                    }
                    
                }
            }

            for(int i =0; i<numerosPares.Length;i++)
            {
                Console.WriteLine("numeros pares digitados: "+numerosPares[i]);
            }


        }
    }
}
