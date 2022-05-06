using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21ExercicosWhile
{
    internal class Exercicio02
    {
        public void Executar()
        {
            string nome = "";
            while (nome != "fim")
            {
                Console.WriteLine("Digite seu nome: ");
                nome = Console.ReadLine();
            }
        }
    }
}
