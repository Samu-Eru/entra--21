using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.BancoDados01.Ado.Net.Models
{
    internal class Editora
    {
        // o que é o get set será apresentado posteriomente
        public int id { get; set; }
        public string Nome { get; set; }
        public decimal Faturamento { get; set; }
        public DateTime DataCriacao { get; set; }
        public string Apelido { get; set; }

    }
}
