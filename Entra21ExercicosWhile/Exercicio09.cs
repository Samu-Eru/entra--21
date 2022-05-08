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
            int multiplicador = 1;
            int resultado = 0;
            while (multiplicador != numeroFatorial)
            {
                if (resultado == 0)
                {
                    resultado = numeroFatorial * multiplicador;
                    Console.WriteLine("Fatorial do número: " + numeroFatorial + " X " + multiplicador + " = " + resultado);
                    multiplicador = multiplicador + 1;
                }
                resultado = resultado * multiplicador;
                Console.WriteLine("Fatorial do número: " + numeroFatorial+" X "+ multiplicador+" = " + resultado);
                multiplicador = multiplicador + 1;
            }

        }
    }
}
