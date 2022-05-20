using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosVetores
{
    internal class Exercicio04
    {
        public void Executar()
        {
            double[] notas = new double[4];
            Console.WriteLine("Digite o nome do aluno: ");
            string nome = Console.ReadLine();
            double media = 0;
            for (var i = 0;i<notas.Length;i++)
            {
                Console.Write("Digite  a " + (i + 1) + "° nota ");
                notas[i] = Convert.ToDouble(Console.ReadLine());
                media = media + notas[i];
            }
            Console.WriteLine("Média: " + (media / notas.Length));
        }
    }
}
