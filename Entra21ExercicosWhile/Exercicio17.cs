using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21ExercicosWhile
{
    internal class Exercicio17
    {
        public void Executar()
        {
            int hora = 23;
            int minuto = 59;
            int segundo = 59;
   
            while (hora >=0)
            {
                while(minuto>=0)
                {
                    while(segundo>=0)
                    {

                        Console.WriteLine(hora+":"+minuto+":"+segundo);
                        segundo = segundo - 1;
                    }
                    minuto = minuto - 1;
                    segundo = 59;
                }
                hora = hora - 1;
                minuto = 59;
               
            }
            
        }
    }
}
