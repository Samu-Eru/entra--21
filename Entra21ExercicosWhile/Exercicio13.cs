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

            int caracteresMaiorNome = 0;
            int caracteresMenorNome = 10000;
            string maiorNome = "";
            string menorNome = "";
            int maiorIdade = 0;
            double menorPeso = 1000;
            double maiorAltura = 0;
            int quantidadeMasculino = 0;
            int quantidadeFeminino = 0;
            int maisGolsMarcados = 0;
            int maisCartoesVermelhos = 0;
            int maisCartoesAmarelos = 0;
            int jogadores = 0;

            while (jogadores != 3)
            {
                Console.Write("Nome: ");
                string nome = Console.ReadLine().Trim();
                int tamanhoNome = nome.Length;
                Console.Write("idade: ");
                int idade = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Peso: ");
                double peso = Convert.ToDouble(Console.ReadLine());
                Console.Write("Sexo: (M/F) ");
                string sexo = Console.ReadLine().ToUpper();
                Console.Write("Altura: ");
                double altura = Convert.ToDouble(Console.ReadLine());
                Console.Write("Quantidade de gols marcados :");
                int golsMarcados = Convert.ToInt32(Console.ReadLine());
                Console.Write("Quantidade de cartões amarelos recebidos: ");
                int cartoesAmarelos = Convert.ToInt32(Console.ReadLine());
                Console.Write("Quantidade de cartôes vermelhos recebidos: ");
                int cartoesVermelhos = Convert.ToInt32(Console.ReadLine());



                //Descobrir Menor peso
                if (peso < menorPeso)
                {
                    menorPeso = peso;
                }


                //Descobrir Maior altura
                if (altura > maiorAltura)
                {
                    maiorAltura = altura;
                }

                
                //Descobrir Maior
                if (tamanhoNome > caracteresMaiorNome)
                {
                    maiorNome = nome;
                    caracteresMaiorNome = maiorNome.Length;
                }
                //Menor nome 
                if (tamanhoNome < caracteresMenorNome)
                {
                    menorNome = nome;
                    caracteresMenorNome = nome.Length;
                 }
                



                //Descobrir quantidade masculino e quantidade feminino
                if (sexo == "M")
                {
                    quantidadeMasculino = quantidadeMasculino + 1;
                }
                else if (sexo == "F")
                {
                    quantidadeFeminino = quantidadeFeminino + 1;
                }
                else
                {
                    Console.WriteLine("Inválido!!!!!");
                }





                jogadores = jogadores + 1;
            }
            Console.WriteLine("Menor peso: " + menorPeso);
            Console.WriteLine("Maior Altura: " + maiorAltura);
            Console.WriteLine("Maior nome: " + maiorNome);
            Console.WriteLine("Menor nome: " + menorNome);
            Console.WriteLine("Maior altura: " + maiorAltura);
            Console.WriteLine("Quantidade de Masculinos: " + quantidadeMasculino);
            Console.WriteLine("Quantidade de Feminino: " + quantidadeFeminino);
        }
    }
}
