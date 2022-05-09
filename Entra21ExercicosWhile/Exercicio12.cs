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
            while (codigoProduto != 7)
            {
                Console.WriteLine("Cód   |   Tipo   |    Nome   |    Valor");
                Console.WriteLine("1 | Bolos | Bolo Brigadeiro | R$ 29,50");
                Console.WriteLine("2 | Bolos | Leite com nutella | R$ 29,23,");
                Console.WriteLine("3 | Sanduiches | Provolone com salame | R$ 19,70");
                Console.WriteLine("4 | Sanduiches | Só salame | R$ 12,70");
                Console.WriteLine("5 | Pizzas | Calabresa | R$ 9,98");
                Console.WriteLine("6 | Pizzas | Vento | R$ 16,78");
                Console.WriteLine("7 : SAIR");
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
                Console.Clear();
            }
            Console.WriteLine("Total de pedidos: " + totalPedidos);
            Console.WriteLine("Valor total: " + valorTotal);
        }

    }
}
