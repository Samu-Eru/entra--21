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
            string nomeMaiorPessoa = "";
            string[] pessoas = new string[9];
            for (var i = 0; i < idades.Length; i++)
            {
                Console.Write("Digite o nome da [" + (i + 1) + "] pessoa: ");
                pessoas[i] = Console.ReadLine();

                Console.Write("Digite a [" + (i + 1) + "] idade: ");
                idades[i] = Convert.ToDouble(Console.ReadLine());
                
                if (idades[i] > maiorIdade)
                {
                    maiorIdade = idades[i];
                    nomeMaiorPessoa = pessoas[i];
                }
            }

            Console.WriteLine("Nome da pessoa com a maior idade: " + nomeMaiorPessoa+" | idade: "+ maiorIdade);
        }
    }
}
