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
            
            while(hora <= 23)
            {
                while(minuto<=23)
                {
                    while(segundo<=59)
                    {
                        segundo = segundo - 1;

                    }
                }
            }
            
        }
    }
}
