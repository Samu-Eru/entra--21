using Entra21.BancoDados01.Ado.Net.DataBase;
using Entra21.BancoDados01.Ado.Net.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.BancoDados01.Ado.Net.Services
{
    //Dois pontos seguidos de uma interface, quer dizer que a classe será obrigada a implementar os métodos(contratos)
    //estabelecidos na interface
    internal class TipoPersonagemService : ITipoPersonagemService
    {
        public void Apagar(int id)
        {
           //comectar com o bd
           var conexao = new Conexao().Conectar();

            //Criar comando para ececutar p delete
            var comando = conexao.CreateCommand();

            comando.CommandText = "DELETE FROM tipos_personagens WHERE id = " + id;

            //Executado o comadno para apahar o registro
            comando.ExecuteNonQuery();

            //fechar conexãso com o bd
            comando.Connection.Close();
        }

        public void Cadastrar(TipoPersonagem tipoPersonagem)
        {
            //Será descrito a implementação do contrato definido na interface

            //Criando conexçao com o Banco DeDados e aberta a conexão
            var conexao = new Conexao().Conectar();

            //Criar comando para executar no banco de dados
            SqlCommand comando = conexao.CreateCommand();

            //especificado o comadno que será executado
            comando.CommandText = "INSERT INTO tipos_personagens (tipo) VALUES ('" + tipoPersonagem.Tipo + "')";

            //Executado o comando de insert na tabela de tipos personagens
            comando.ExecuteNonQuery();

            conexao.Close();
        }

        public List<TipoPersonagem> ObterTodos()
        {
            var conexao = new Conexao().Conectar();

            //Criando conexão com o Banco deDados e aberta a conexão
            var comando = conexao.CreateCommand();

            comando.CommandText = "SELECT id, tipo FROM tipos_personagens";

            //Croiado tabela em memória para psoteriormente carregar os registros obtidos com o SELECT
            var tabelaEmMemoria = new DataTable();

            //Carregadno na tabela em memória os registros encontrados com o comando SELECT
            tabelaEmMemoria.Load(comando.ExecuteReader());

            //Criado uma lis para armazenar os registros da consulta do SELECT  
            var tiposPersonagens = new List<TipoPersonagem>();

            //Percorrido cada um dos registros da tabelaEmMemoria(registros do SELECT);
            for (int i = 0; i < tabelaEmMemoria.Rows.Count; i++)
            {
                //Obtido o registro da linha que está sendo percorrida
                var linha = tabelaEmMemoria.Rows[i];

                //Instanciado objeto da classe TipoPersonagem Preenchendo com as informaçoes do SELECY,
                //da linha que está sendo percorrdia
                var tipoPersonagem = new TipoPersonagem();
                tipoPersonagem.id = Convert.ToInt32(linha["id"].ToString());
                tipoPersonagem.Tipo = linha["tipo"].ToString();

                //Adiconado tipoPersonagens instanciado na lista de TiposPersonagens
                tiposPersonagens.Add(tipoPersonagem);
            }

            //Fechando a conexõa com o banco de dados
            comando.Connection.Close();

            return tiposPersonagens;
        }
    }
}
