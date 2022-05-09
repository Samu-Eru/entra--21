using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21ExercicosWhile
{
    internal class Exercicio13
    {
        public void Executar()
        {
            Console.WriteLine(@"-----------------------Estatistica de Jogadores-----------------------");

            int quantidadeCaracteresNome = 0;
            int maiorIdade = 0;
            double menorPeso = 1000;
            double maiorAltura = 0;
            string sexo = "";
            int maisGolsMarcados = 0;
            int maisCartoesVermelhos = 0;
            int maisCartoesAmarelos = 0;
            int jogadores = 0;

            while (jogadores != 3)
            {
                Console.Write("Nome: ");
                string nome = Console.ReadLine().Trim();
                quantidadeCaracteresNome = nome.Length;
                Console.Write("idade: ");
                int idade = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Peso: ");
                double peso = Convert.ToDouble(Console.ReadLine());
                Console.Write("Sexo: (M/F) ");
                sexo = Console.ReadLine();
                Console.Write("Altura: ");
                double altura = Convert.ToDouble(Console.ReadLine());
                Console.Write("Quantidade de gols marcados :");
                int golsMarcados = Convert.ToInt32(Console.ReadLine());
                Console.Write("Quantidade de cartões amarelos recebidos: ");
                int cartoesAmarelos = Convert.ToInt32(Console.ReadLine());
                Console.Write("Quantidade de cartôes vermelhos recebidos: ");
                int cartoesVermelhos = Convert.ToInt32(Console.ReadLine());

                


              if (peso <menorPeso)
                {
                    menorPeso = peso;
                }
              if(altura>maiorAltura)
                {
                    maiorAltura = altura;
                }
              if(quantidadecaracteresNome > )






                jogadores = jogadores + 1;
            }
            Console.WriteLine("Maior peso: " + menorPeso);
        }
    }
}
