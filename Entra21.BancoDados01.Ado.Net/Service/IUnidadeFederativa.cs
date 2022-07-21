using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entra21.BancoDados01.Ado.Net.Models;

namespace Entra21.BancoDados01.Ado.Net.Service
{
    internal interface IUnidadeFederativa
    {
        void Cadastrar(unidades_federativas unidade_federativa);
        List<unidades_federativas> ObterTodos();
        void Apagar(int id);
        unidades_federativas ObterPorId(int id);
        void Editar(unidades_federativas unidade_federativa);
    }
}
