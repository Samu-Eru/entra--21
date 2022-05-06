using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExemplosWhile
{
    internal class Exemplo01
    {
        public void Executar()
        {
            int indiceAuxiliar = 0;

            while (indiceAuxiliar < 3)
            {
                Console.WriteLine("Digite um numero: ");
                int numero = Convert.ToInt32(Console.ReadLine());


                indiceAuxiliar = indiceAuxiliar + 1;

            }
        }
    }
}
