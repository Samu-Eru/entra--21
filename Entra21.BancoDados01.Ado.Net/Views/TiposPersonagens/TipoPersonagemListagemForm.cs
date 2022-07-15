using Entra21.BancoDados01.Ado.Net.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entra21.BancoDados01.Ado.Net.Views.TiposPersonagens
{
    public partial class TipoPersonagemListagemForm : Form
    {
        private TipoPersonagemService tipoPersonagemService;
        public TipoPersonagemListagemForm()
        {
            InitializeComponent();
            tipoPersonagemService = new TipoPersonagemService();
        }

        private void TipoPersonagemListagemForm_Load(object sender, EventArgs e)
        {
            AtualizarRegistrosDataGridView(); 
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            var tipoPersonagemCadastroEdicaoForm = new TipoPersonagemCadastroEdicaoForm();

            tipoPersonagemCadastroEdicaoForm.ShowDialog();

            AtualizarRegistrosDataGridView();
        }

        private void AtualizarRegistrosDataGridView()
        {
            //Obter todos os tipos de personagens cadastrados na tabela
            //tipos_persoagens
            var tiposPersonagens = tipoPersonagemService.ObterTodos();

            dataGridView1.Rows.Clear();

            //Percorrido todos os tipos de personagens encontrados para adicionar no DATAGRID permitindo o usuarioa visualiza-los
            for (int i = 0; i < tiposPersonagens.Count; i++)
            {
                var tipoPersonagem = tiposPersonagens[i];
                dataGridView1.Rows.Add(new object[]
                {
                    tipoPersonagem.id,
                    tipoPersonagem.Tipo
                });
            }
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

            tipoPersonagemService.Apagar(id);

            AtualizarRegistrosDataGridView();
            MessageBox.Show("Registro apagado com sucesso!");
        }
    }
}
