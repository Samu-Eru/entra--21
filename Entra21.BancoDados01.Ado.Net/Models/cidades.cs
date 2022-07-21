using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.BancoDados01.Ado.Net.Models
{
    internal class cidades
    {
        public int id { get; set; }
        public string nome { get; set; }
        public int quantidade_habitantes { get; set; }
        public DateTime data_hora_fundacao { get; set; }

        //lembrar do inner join
        public unidades_federativas id_unidade_federativa  { get; set; }
    }
}
