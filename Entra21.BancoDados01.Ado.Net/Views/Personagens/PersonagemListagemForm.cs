﻿using Entra21.BancoDados01.Ado.Net.Models;
using Entra21.BancoDados01.Ado.Net.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entra21.BancoDados01.Ado.Net.Views.Personagens
{
    public partial class PersonagemListagemForm : Form
    {
        //Definindo con readonly será permitida a criação da instancia somente no construtor
        private readonly PersonagemService _personagemService;
        
        // AQUI fica o construtor: tem como objetivo construir o objeto com Propriedades necessárias e execuçõa de métodos obrigatórios, ou seja,
        // neste cenário desenhar a tela e instanciar o objeto do serviço que permitirá gerenciar os dados referentes ao personagem

        public PersonagemListagemForm()
        {
            InitializeComponent();

            _personagemService = new PersonagemService();

            PreencherDataGridViewComPersonagens();
        }

        private void PreencherDataGridViewComPersonagens()
        {
            var personagens = _personagemService.ObterTodos();

            dataGridView1.Rows.Clear();

            for(int i = 0; i < personagens.Count; i++)
            {
                var personagem = personagens[i];

                dataGridView1.Rows.Add(new object[]
                {
                    personagem.Id,
                    personagem.Nome,
                    personagem.TipoPersonagem.Tipo,
                    personagem.Editora.Nome
                });
            }
        }

        private void buttonCadastro_Click(object sender, EventArgs e)
        {
            var personagemForm = new PersonagemCadastroEdicaoForm();
            personagemForm.ShowDialog();

            PreencherDataGridViewComPersonagens();
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um registro");
                return;
            }

            var linhaSelecionada = dataGridView1.SelectedRows[0];

            var id = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            _personagemService.Apagar(id);

            PreencherDataGridViewComPersonagens();

            MessageBox.Show("Registro removido com sucesso");
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Querido usuario, selecione algum registro nesse trem!");
                return;
            }

            var linhasSelecionada = dataGridView1.SelectedRows[0];

            var id = Convert.ToInt32(linhasSelecionada.Cells[0].Value);

            var personagem = _personagemService.ObterPorId(id);

            var personagemCadastroForm = new PersonagemCadastroEdicaoForm(personagem);
            personagemCadastroForm.ShowDialog();

            PreencherDataGridViewComPersonagens();
        }
    }
}
