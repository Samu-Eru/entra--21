using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entra21.BancoDados01.Ado.Net.DataBase;
using Entra21.BancoDados01.Ado.Net.Models;

namespace Entra21.BancoDados01.Ado.Net.Service
{
    internal class UnidadeFederativaService : IUnidadeFederativa
    {
        public void Apagar(int id)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();
            comando.CommandText = "DELETE FROM unidade_federativa WHERE id = @ID";

            comando.Parameters.AddWithValue("@ID", id);

            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        public void Cadastrar(unidades_federativas unidade_federativa)
        {

            var conexao = new Conexao().Conectar();

            SqlCommand comando = conexao.CreateCommand();

            comando.CommandText = "INSERT INTO unidade_federativa (nome, sigLa) Values(@NOME, @SIGLA)";
            comando.Parameters.AddWithValue("@NOME", unidade_federativa.nome);
            comando.Parameters.AddWithValue("@SIGLA", unidade_federativa.sigla);

            comando.ExecuteNonQuery();

            conexao.Close();
        }

        public void Editar(unidades_federativas unidade_federativa)
        {
            var conexao = new Conexao().Conectar();

            var comando = conexao.CreateCommand();
            comando.CommandText =
                "UPDATE unidade_federativa SET nome = @NOME, sigla = @SIGLA WHERE id = @ID";
            comando.Parameters.AddWithValue("@NOME", unidade_federativa.nome);
            comando.Parameters.AddWithValue("@SIGLA", unidade_federativa.sigla);
            comando.Parameters.AddWithValue("@ID", unidade_federativa.id);

            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        public unidades_federativas ObterPorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<unidades_federativas> ObterTodos()
        {
            throw new NotImplementedException();
        }
    }
}
