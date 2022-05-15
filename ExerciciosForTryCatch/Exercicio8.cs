using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosForTryCatch
{
    internal class Exercicio8
    {
        public void Executar()
        {
            var valorValido = false;
            while(valorValido == false)
            try
            {
                Console.Write("Digite um numero para ser exibir sua tabuada até 1000: ");
                var numero = Convert.ToInt32(Console.ReadLine());

                for (var i = 0; i <= 1000; i++)
                {
                    Console.WriteLine(numero + " X " + i + " = " + (numero * i));
                    Console.WriteLine("------------------------------------------");
                }
                    valorValido = true;
            }
            catch(Exception ex)
            {
                Console.WriteLine("Valor Digitado inválido!");
            }
        }
    }
}
