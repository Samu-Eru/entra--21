using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosForTryCatch
{
    internal class Exercicio10
    {
        public void Executar()
        {
           var valorValido = false;
           while(valorValido == false) 
            try
            {


                Console.WriteLine("Digite um número para ser exibido seus 50 números antecessores pares e seus 50 sucessores ímpares: ");
                var numero = Convert.ToInt32(Console.ReadLine());
                var antecesoorSucessor = numero - 50;
                Console.WriteLine("Pares:");



                for (var i = numero; i >= antecesoorSucessor; i--)
                {

                    if ((i % 2) == 0)
                    {
                        Console.WriteLine("    " + i);
                    }

                }

                Console.WriteLine("");
                Console.WriteLine("Ímpares");
                antecesoorSucessor = numero + 50;
                for (var j = numero; j <= antecesoorSucessor; j++)
                {
                    if ((j % 2) == 1)
                    {
                        Console.WriteLine("    " + j);
                    }
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
