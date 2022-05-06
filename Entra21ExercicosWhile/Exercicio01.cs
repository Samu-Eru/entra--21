using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21ExercicosWhile
{
    internal class Exercicio01
    {
        public void Executar()
        {
            int indice = 1;
            string nomePeca = "";
            string precoPeca = "";
            while (indice <= 13)
            {
                Console.WriteLine("Digite o nome da " + indice + "° peça: ");
                nomePeca = Console.ReadLine();
                Console.WriteLine("Digite o preço da " + indice + "° peça");
                precoPeca = Console.ReadLine();
                indice = indice + 1;
            }

        }
    }
}
