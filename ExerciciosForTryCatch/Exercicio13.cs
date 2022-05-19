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
            var nome = "";
            var tamanhoNome = 0;
            var idade = 0;
            var peso = 0.0;
            var altura = 0.0;
            var cartoesAmarelos = 0;
            var cartoesVermelhos = 0;


            var menorPeso = double.MaxValue;
            var maiorPeso = double.MinValue;
            var maiorAltura = double.MinValue;
            var maiorNome = 0;
            var nomeMaiorNome = "";
            var menorNome = int.MaxValue;
            var nomeMenorNome = "";
            var quantidadeMasculino = 0;
            var quantidadeFeminino = 0;
            var menosCartoesAmarelos = int.MaxValue;
            var nomeJogadorMenosAmarelos = "";
            var maiorCartoesVermelho = 0;
            var nomeJogadorMaisVermelho = "";
            var maiorCartoesAmarelos = 0;
            var nomeJogadorMaisAmarelos = "";
            var menorCartoesVermelhos = int.MaxValue;
            var nomeJogadormenosVermelhos = "";

            for (var i = 0; i < 2; i++)
            {
                var nomeValido = false;
                while (nomeValido == false)
                {
                    try
                    {
                        Console.Write("Nome: ");
                        nome = Console.ReadLine().Trim();
                        tamanhoNome = nome.Length;

                        if (tamanhoNome <3)
                        {
                            Console.WriteLine("Nome inválido");
                        }
                        else
                        {
                            nomeValido = true;
                        }

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("INVÁLIDO!!!!!!!");
                    }
                }

                var idadeValida = false;
                while (idadeValida == false)
                {
                    try
                    {
                        Console.Write("idade: ");
                        idade = Convert.ToInt32(Console.ReadLine());
                        idadeValida = true;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Valor inválido!");
                    }
                }

                var pesoValido = false;
                while (pesoValido == false)
                {
                    try
                    {
                        Console.WriteLine("Peso: ");
                        peso = Convert.ToDouble(Console.ReadLine());
                        pesoValido = true;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Valor inválido!");
                    }
                }


                var sexoValido = false;
                while (sexoValido == false)
                {
                    try
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
                    catch (Exception ex)
                    {
                        Console.WriteLine("Valor inválido");
                    }
                }

                var alturaValida = false;
                while (alturaValida == false) 
                {
                    try
                    {

                        Console.Write("Altura: ");
                        altura = Convert.ToDouble(Console.ReadLine());
                        alturaValida = true;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Valor inválido");
                    }
                }

                var quantidadeGolsValidos = false;
                while (quantidadeGolsValidos == false)
                {
                    try
                    {
                        Console.Write("Quantidade de gols marcados :");
                        var golsMarcados = Convert.ToInt32(Console.ReadLine());
                        quantidadeGolsValidos = true;
                    }
                    catch
                    {
                        Console.WriteLine("Valor inválido!");
                    }
                }

                var amarelosRecebidosValidos = false;
                while (amarelosRecebidosValidos == false)
                {
                    try
                    {
                        Console.Write("Quantidade de cartões amarelos recebidos: ");
                        cartoesAmarelos = Convert.ToInt32(Console.ReadLine());
                        amarelosRecebidosValidos = true;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Valor inválido!");
                    }
                }

                var vermelhosRecebidosValidos = false;
                while (vermelhosRecebidosValidos == false)
                {
                    try
                    {
                        Console.Write("Quantidade de cartôes vermelhos recebidos: ");
                        cartoesVermelhos = Convert.ToInt32(Console.ReadLine());
                        vermelhosRecebidosValidos = true;
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine("Valor inválido");
                    }
                }
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
                    maiorNome = tamanhoNome;
                }
                if (cartoesAmarelos < menosCartoesAmarelos)
                {
                    menosCartoesAmarelos = cartoesAmarelos;
                    nomeJogadorMenosAmarelos = nome;
                }
                if (tamanhoNome < menorNome)
                {
                    nomeMenorNome = nome;
                    menorNome = tamanhoNome;
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
                if (cartoesAmarelos>maiorCartoesAmarelos)
                {
                    maiorCartoesAmarelos = cartoesAmarelos;
                    nomeJogadorMaisAmarelos = nome;
                }
                if (cartoesVermelhos<menorCartoesVermelhos)
                {
                    menorCartoesVermelhos = cartoesVermelhos;
                    nomeJogadormenosVermelhos = nome;
                }

            }
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Jogador com o menor peso: "+menorPeso);
            Console.WriteLine("Jogador com a maior altura: "+maiorAltura);
            Console.WriteLine("Jogador com o maior nome: "+nomeMaiorNome +","+ maiorNome+" caracteres");
            Console.WriteLine("Quantidade de jogadores do sexo feminino: "+quantidadeFeminino);
            Console.WriteLine("Quantidade de jogadores do sexo masculino: "+quantidadeMasculino);
            Console.WriteLine("Jogador com a menor quantidade de cartões amarelos recebidos: "+nomeJogadorMenosAmarelos+", quantidade de amarelos: "+menosCartoesAmarelos);
            Console.WriteLine("Jogador com o menor nome:  "+nomeMenorNome+","+menorNome+" caracteres");
            Console.WriteLine("Jogador com o maior peso: "+maiorPeso);
            Console.WriteLine("Jogador com a maior quantidade de cartôes vermelhos recebidos: "+nomeJogadorMaisVermelho+","+maiorCartoesVermelho+" vermelhos");
            Console.WriteLine("Jogador com a maior quantidade de cartôes amarelos recebidos: "+nomeJogadorMenosAmarelos+","+maiorCartoesAmarelos+" amarelos");
            Console.WriteLine("Jogador com a menor quantidade de cartões vermelhos recebidos: "+nomeJogadormenosVermelhos+","+menorCartoesVermelhos+"vermelhos");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");        
        }
    }
}
