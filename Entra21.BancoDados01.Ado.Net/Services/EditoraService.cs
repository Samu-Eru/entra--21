﻿using Entra21.BancoDados01.Ado.Net.DataBase;
using Entra21.BancoDados01.Ado.Net.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.BancoDados01.Ado.Net.Services
{
    internal class EditoraService : iEditoraService
    {
        public List<Editora> ObterTodos()
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();
            comando.CommandText = "SELECT id, nome, apelido, data_criacao, faturamento FROM editoras";

            //Instanciando tabela em mem´roia para armazenar os registros da consulta
            var tabelaEmMemoria = new DataTable();
            // Executa o consulta SELelct
            tabelaEmMemoria.Load(comando.ExecuteReader());

            //Cria lista para armazenar as editoras
            var editoras = new List<Editora>();

            for (int i = 0; i < tabelaEmMemoria.Rows.Count; i++)
            {
                var linha = tabelaEmMemoria.Rows[i];

                var editora = new Editora();
                editora.id = Convert.ToInt32(linha[0]);
                editora.Nome = linha[1].ToString();
                editora.Apelido = linha[2].ToString();
                editora.DataCriacao = Convert.ToDateTime(linha[3]);
                editora.Faturamento = Convert.ToDecimal(linha[4]);

                editoras.Add(editora);

            }
            //Fechar a conexão
            conexao.Close();

            return editoras;
            

        }

    }
}
