using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosVetores
{
    internal class Exercicio01
    {
        public void Executar()
        {
            int [] numeros = new int[16];
            int soma = 0;
            for (int i = 0; i <numeros.Length;i++)
            {
                Console.WriteLine("Digite o [" + (i + 1) + "] valor:");
                numeros[i] = Convert.ToInt32(Console.ReadLine());

                soma = soma + numeros[i];
            }
            Console.WriteLine("Soma de todos os valores: " + soma);
        }
    }
}
