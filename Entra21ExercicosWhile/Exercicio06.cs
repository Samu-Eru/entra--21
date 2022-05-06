using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21ExercicosWhile
{
    internal class Exercicio06
    {
        public void Executar()
        {
            string nome = "";
            double valorProduto = 0;
            int quantidadeProdutos = 0;
            double precoTotal = 0;
            while (nome != "sair")
            {
                Console.Write(" Nome do produto: ");
                nome = Console.ReadLine();
                if (nome != "sair")
                {
                    Console.Write("Valor do produto: ");
                    valorProduto = valorProduto + Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("quantidade de produtos: ");
                    quantidadeProdutos = quantidadeProdutos + Convert.ToInt32(Console.ReadLine());

                }

            }
            precoTotal = valorProduto * quantidadeProdutos;
            double desconto = precoTotal * 0.05;
            Console.WriteLine("Valor Total da compra com desconto de 5%: " + (precoTotal - desconto));
        }
    }
}
