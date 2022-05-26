using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemplosOrientacaoObjetos
{
    public class Produto
    {
        public string Nome;
        public DateTime DataFabricacao;
        public DateTime DataVencimento;


        public bool EhVencido()
        {
            var dataHoje = DateTime.Today;

            if (DataVencimento > dataHoje)
            {
                return false;
            }
            return true;

        }

        public bool EstaEmPromocao()
        {
            var vencido = EhVencido();

            if (vencido == true)
            {
                return false;
            }

            var dataHoje = DateTime.Today;

            var dataParaPromocao = DataVencimento.AddDays(-3);

            var dataInicioPromocao = DataVencimento.AddDays(-3);
            var dataTerminoPromocao = DataVencimento.AddDays(-1);

            if (dataHoje >= dataInicioPromocao && dataHoje <= dataTerminoPromocao)
            {
                return true;
            }
            return false;
        }
    }
}
