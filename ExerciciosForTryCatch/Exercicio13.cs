using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosForTryCatch
{
    internal class Exercicio13
    {
        public void Executar()
        {
            var menorPeso = 99999.0;
            var maiorPeso = 0.0;
            var maiorAltura = 0.0;
            var maiorNome = 0;
            var nomeMaiorNome = "";
            var menorNome = 9999;
            var nomeMenorNome = "";
            var quantidadeMasculino = 0;
            var quantidadeFeminino = 0;
            var menosCartoesAmarelos = 9999;
            var nomeJogadorMenosAmarelos = "";
            var maiorCartoesVermelho = 0;
            var nomeJogadorMaisVermelho = "";
            var maiorCartoesAmarelos = 0;
            var nomeJogadorMaisAmarelos = "";
            var menorCartoesVermelhos = 9999;
            var nomeJogadormenosVermelhos = "";
            for (var i = 0; i < 22; i++)
            {
                Console.Write("Nome: ");
                var nome = Console.ReadLine().Trim();
                var tamanhoNome = nome.Length;
                Console.Write("idade: ");
                var idade = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Peso: ");
                var peso = Convert.ToDouble(Console.ReadLine());



                var sexoValido = false;
                while (sexoValido == false)
                {
                    Console.Write("Sexo: (M/F) ");
                    var sexo = Console.ReadLine().ToUpper();

                    if (sexo == "M")
                    {
                        quantidadeMasculino += 1;
                        sexoValido = true;
                    }
                    else if (sexo == "F")
                    {
                        quantidadeFeminino += 1;
                        sexoValido = true;
                    }
                    else
                    {
                        Console.WriteLine("Opção inválida!");
                    }
                }



                Console.Write("Altura: ");
                var altura = Convert.ToDouble(Console.ReadLine());
                Console.Write("Quantidade de gols marcados :");
                var golsMarcados = Convert.ToInt32(Console.ReadLine());
                Console.Write("Quantidade de cartões amarelos recebidos: ");
                var cartoesAmarelos = Convert.ToInt32(Console.ReadLine());
                Console.Write("Quantidade de cartôes vermelhos recebidos: ");
                var cartoesVermelhos = Convert.ToInt32(Console.ReadLine());

                if (peso < menorPeso)
                {
                    menorPeso = peso;
                }
                if (altura > maiorAltura)
                {
                    maiorAltura = altura;
                }
                if (tamanhoNome > maiorNome)
                {
                    nomeMaiorNome = nome;
                }
                if (cartoesAmarelos < menosCartoesAmarelos)
                {
                    menosCartoesAmarelos = cartoesAmarelos;
                    nomeJogadorMenosAmarelos = nome;
                }
                if (tamanhoNome < menorNome)
                {
                    nomeMenorNome = nome;
                }
                if (peso > maiorPeso)
                {
                    maiorPeso = peso;
                }
                if (cartoesVermelhos > maiorCartoesVermelho)
                {
                    maiorCartoesVermelho = cartoesVermelhos;
                    nomeJogadorMaisVermelho = nome;                
                }
                if(cartoesAmarelos>maiorCartoesAmarelos)
                {
                    maiorCartoesAmarelos = cartoesAmarelos;
                    nomeJogadorMaisAmarelos = nome;
                }
                if(cartoesVermelhos<menorCartoesVermelhos)
                {
                    menorCartoesVermelhos = cartoesVermelhos;
                    nomeJogadormenosVermelhos = nome;
                }

            }
            Console.WriteLine(@"");
        }
    }
}
