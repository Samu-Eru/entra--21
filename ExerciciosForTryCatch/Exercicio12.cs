using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosForTryCatch
{
    internal class Exercicio12
    {
        public void Executar()
        {
            Console.WriteLine(@"Cód | Tipo   |      Nome     |    Valor
1 | Bolos | Bolo Brigadeiro | R$ 29,50
2 | Bolos | Leite com nutella | R$ 29,23,
3 | Sanduiches | Provolone  | R$ 19,70
4 | Sanduiches | Só salame | R$ 12,70
5 | Pizzas | Calabresa | R$ 9,98
6 | Pizzas | Vento | R$ 16,78
7 : SAIR");

            var valorTotalPedidos = 0.0;
            var quantidadeBolos = 0;
            var quantidadeSanduiches = 0;
            var quantidadePizzas = 0;

            var digitoValido = false;
            var quantidadeProdutos = 0;

            while (digitoValido == false)
            {
                try
                {
                    Console.WriteLine("Digite a QUANTIDADE de produtos desejados: ");
                    quantidadeProdutos = Convert.ToInt32(Console.ReadLine());
                    digitoValido = true;
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Valor inválido!");
                }
            }
            for (var i = 0; i < quantidadeProdutos; i++)
            {
                digitoValido = false;
                while (digitoValido == false)
                {
                    try
                    {
                        Console.WriteLine("Digite o código do produto [" + (i + 1) + "/" + quantidadeProdutos + "] produto desejado: ");
                        var codigoProdutoDesejado = Convert.ToInt32(Console.ReadLine());

                        if (codigoProdutoDesejado == 1)
                        {
                            valorTotalPedidos += 29.50;
                            quantidadeBolos++;

                            digitoValido = true;
                        }
                        else if (codigoProdutoDesejado == 2)
                        {
                            valorTotalPedidos += 29.23;
                            quantidadeBolos++;

                            digitoValido = true;
                        }
                        else if (codigoProdutoDesejado == 3)
                        {
                            valorTotalPedidos += 19.70;
                            quantidadeSanduiches++;

                            digitoValido = true;
                        }
                        else if (codigoProdutoDesejado == 4)
                        {
                            valorTotalPedidos += 12.70;
                            quantidadeSanduiches++;

                            digitoValido = true;

                        }
                        else if (codigoProdutoDesejado == 5)
                        {
                            quantidadePizzas++;
                            valorTotalPedidos += 9.98;

                            digitoValido = true;
                        }
                        else if (codigoProdutoDesejado == 6)
                        {
                            quantidadePizzas++;
                            valorTotalPedidos += 16.78;

                            digitoValido = true;
                        }
                        else if(codigoProdutoDesejado == 7)
                        {
                            digitoValido = true;
                            i = quantidadeProdutos;
                        }
                        else{
                            Console.WriteLine("Opção não disponível!!");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Valor digitado inválido!!");
                    }
                }
            }
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("Quantidade Bolos escolhidos: " + quantidadeBolos);
            Console.WriteLine("Quantidade sanduiches escolhidos: " + quantidadeSanduiches);
            Console.WriteLine("Qunatidade Pizzas escolhidas: " + quantidadePizzas);
            Console.WriteLine("Média dos produtos: " + (valorTotalPedidos / quantidadeProdutos));
            Console.WriteLine("------------------------------------------------------------------");
        }
    }
}
