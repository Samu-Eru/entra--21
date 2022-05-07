using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21ExercicosWhile
{
    internal class Exercicio09
    {
        public void Executar()
        {
            Console.Write("Fatorial do número: ");
            int numeroFatorial = Convert.ToInt32(Console.ReadLine());
            int multiplicador = numeroFatorial-1;
            
            while (multiplicador != 0)
            {
                int resultado = 0;
                resultado = (numeroFatorial * multiplicador) ;
                int resultadoFinal = (numeroFatorial * multiplicador);
                //int resultadoAnterior = resultado;

                multiplicador = multiplicador - 1;
                Console.WriteLine("Fatorial de " + numeroFatorial + " é: " + resultadoFinal );
            }

        }
    }
}
