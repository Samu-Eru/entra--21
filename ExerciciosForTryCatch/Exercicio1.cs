using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosForTryCatch
{
    internal class Exercicio1
    {
        public void Executar()
        {
            for (var i = 0; i < 5; i++)
            {

                var numeroValido = false;

                while (numeroValido == false)
                {
                    


                    try
                    {

                       Console.Write("Digite o nome da peça: ");
                       var nome = Console.ReadLine();

                        Console.WriteLine("Digite o preço da " + i + "° peça: ");
                        var preco = Convert.ToInt32(Console.ReadLine());
                        numeroValido = true;
                    }
                    catch
                    {
                        Console.WriteLine("Valor digitado inválido!");
                    }
                }
            }
        }
    }
}
