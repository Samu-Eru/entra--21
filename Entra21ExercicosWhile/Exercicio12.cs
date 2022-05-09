using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21ExercicosWhile
{
    internal class Exercicio12
    {
        public void Executar()
        {
            int totalPedidos = 0;
            double valorTotal = 0;
            int codigoProduto = 0;
            int quantidadeBolos = 0;
            int quantidadeSanduiches = 0;
            int quantidadePizza = 0;


            while (codigoProduto != 7)
            {
                Console.WriteLine(@"Cód   |   Tipo   |    Nome   |    Valor
                1 | Bolos | Bolo Brigadeiro | R$ 29,50
                2 | Bolos | Leite com nutella | R$ 29,23,
                3 | Sanduiches | Provolone com salame | R$ 19,70
                4 | Sanduiches | Só salame | R$ 12,70
                5 | Pizzas | Calabresa | R$ 9,98
                6 | Pizzas | Vento | R$ 16,78
                7 : SAIR");

                codigoProduto = Convert.ToInt32(Console.ReadLine());

                if(codigoProduto == 1)
                {
                    valorTotal = valorTotal + 29.50;
                    totalPedidos = totalPedidos + 1;

                }
                else if(codigoProduto == 2)
                {
                    valorTotal = valorTotal + 29.23;
                    totalPedidos = totalPedidos + 1;
                }
                else if (codigoProduto == 3)
                {
                    valorTotal = valorTotal + 19.70;
                    totalPedidos = totalPedidos + 1;
                }
                else if(codigoProduto == 4)
                {
                    valorTotal = valorTotal + 12.70;
                    totalPedidos = totalPedidos + 1;
                }
                else if (codigoProduto == 5)
                {
                    valorTotal = valorTotal + 9.98;
                    totalPedidos = totalPedidos + 1;
                }
                else if (codigoProduto <1 | codigoProduto >7)
                {
                    Console.WriteLine("Opção inválida");
                }
                

                if (codigoProduto == 1 | codigoProduto == 2)
                    {
                    quantidadeBolos = quantidadeBolos + 1;
                }
                else if(codigoProduto == 3 | codigoProduto == 4)
                {
                    quantidadeSanduiches = quantidadeSanduiches + 1;
                }
                else if(codigoProduto == 5 | codigoProduto == 6)
                {
                    quantidadePizza = quantidadePizza + 1;
                }

                Console.Clear();
            }

            Console.WriteLine("Total de pedidos: " + totalPedidos);
            Console.WriteLine("Valor total: " + valorTotal);
            Console.WriteLine("Quantidade de Bolos escolhidos: " + quantidadeBolos);
            Console.WriteLine("Quantidade de Sanduiches escolhidos: " + quantidadeSanduiches);
            Console.WriteLine("Quantidade de Pizzas escolhidos: " + quantidadePizza);
            Console.WriteLine("Média : " + (valorTotal / totalPedidos));

        }

    }
}
