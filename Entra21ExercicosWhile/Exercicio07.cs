using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21ExercicosWhile
{
    internal class Exercicio07
    {
        public void Executar()
        {
            int quantidadeProduto = 0;
            double valorComDesconto = 0;
            double valorTotal = 0;
            while (quantidadeProduto <5)
            {
                Console.Write("Digite o nome do produto: ");
                string nome = Console.ReadLine();
                Console.Write("Digite o valor do produto: "+ quantidadeProduto);
                double valor = Convert.ToDouble(Console.ReadLine());
                valorTotal = valorTotal + valor;
                valorComDesconto = valorTotal - 150;
                quantidadeProduto = quantidadeProduto + 1;
              
            }
            Console.Write("Valor Total com desconto " + valorComDesconto);
        }
    }
}
