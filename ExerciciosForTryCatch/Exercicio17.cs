using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosForTryCatch
{
    internal class Exercicio17
    {
        public void Executar()
        {
            var data = new DateTime(2008, 3, 1, 23, 59, 59);
            var hora = data.Hour;
            

            for (; hora>=0;hora--)
            {
                for (var minuto=data.Minute; minuto>=0;minuto--)
                {

                    for (var segundo=data.Second; segundo>=0; segundo--)
                    {
                        Console.WriteLine(hora+":"+minuto+":"+segundo);
                    }
                }
            }
        }
    }
}
