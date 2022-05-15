using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosForTryCatch
{
    internal class Exercicio5
    {
        public void Executar()
        {
            var quantidadeDeCadastros = 0;
            Console.Clear();

            var quantidadeValida = false;
            while (quantidadeValida == false)
            {
                try
                {
                    Console.WriteLine("Quantidade de carros a serem cadastrados: ");
                    quantidadeDeCadastros = Convert.ToInt32(Console.ReadLine());
                    if (quantidadeDeCadastros < 1)
                    {
                        Console.WriteLine("número de cadastros não pode ser 0 ou negativa");
                    }
                    else
                    {
                        quantidadeValida = true;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Valor Digitado inválido! ");
                }

            }

            var mediaAno = 0.0;
            var mediaValor = 0.0;
            var quantidadeComG = 0;
            var quantidadeComA = 0;
            for (var i = 0; i < quantidadeDeCadastros; i++)
            {
                var valorEAnovalido = false;

                while (valorEAnovalido == false)
                {
                    try
                    {
                        Console.Write("Digite o modelo do " + i + " carro: ");
                        var modelo = Console.ReadLine().Trim().ToLower();
                        Console.Write("Digite o valor do " + i + " carro: ");
                        var valor = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Digite o ano do " + i + " carro: ");
                        var ano = Convert.ToInt32(Console.ReadLine());
                        mediaAno = mediaAno + ano;
                        mediaValor = mediaValor + valor;

                        if (modelo.StartsWith("g"))
                        {
                            quantidadeComG = quantidadeComG++;
                        }
                        else if (modelo.StartsWith("s"))
                        {
                            quantidadeComA = quantidadeComA++;
                        }
                        valorEAnovalido = true;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Valor digitado inválido!");
                    }

                }

            }
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("Média ano dos carros cadastrados: " + mediaAno / quantidadeDeCadastros);
            Console.WriteLine("Média valor dos carros cadastrados: " + mediaValor / quantidadeDeCadastros);
            Console.WriteLine("Média de modelos que iniciam com a letra G: " + quantidadeComG);
            Console.WriteLine("Média de modelos que iniciam com a letra A: " + quantidadeComA);
            Console.WriteLine("---------------------------------------------------------------------------");
        }
    }
}
