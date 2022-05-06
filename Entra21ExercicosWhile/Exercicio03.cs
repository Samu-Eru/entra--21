using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21ExercicosWhile
{
    internal class Exercicio03
    {
        public void Executar()
        {
            int idade = 0;
            while (idade < 128)
            {
                Console.Write("idade: ");
                idade = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
