using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entra21.ExemplosWindowsForms.Exemplo01
{
    public partial class EnderecosForm : Form
    {
        private EnderecoServico enderecoServico;


        //Construtor: constuir o objeto que está sendo instanciado com as devidas informações ou rotinas
        public EnderecosForm()
        {
            InitializeComponent();


            enderecoServico = new EnderecoServico();

            //Deve apresentar os dados quando a tela for carregada
            PreencherDataGridViewComEnderecos();
        
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            maskedTextBoxCEP.Text = "";
            textBoxEnderecoCompleto.Text = "";
            comboBoxPaciente.SelectedIndex = -1;

        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            // Obter os dados preenchidas pelo usuário armazenando em varieáveis
            var cep = maskedTextBoxCEP.Text;
            var enderecoCompleto = textBoxEnderecoCompleto.Text;
            var paciente = comboBoxPaciente.SelectedItem;

            //Construir o obejeto de endereco com as variáveis 
            var endereco = new Endereco();
            endereco.Cep = cep;
            endereco.EnderecoCompleto = enderecoCompleto;
            //endereco.Paciente = paciente;

            //Salavr ente endereco na lista de enderecos e no arquivo JSON
            enderecoServico.Adicionar(endereco);

            //Apresentar o registro novo no DataGridView
            PreencherDataGridViewComEnderecos();

        }

        public void PreencherDataGridViewComEnderecos()
        {
            //Obter todos os enderecos da lista de enderecos
            var enderecos = enderecoServico.ObtemTodos();

            //Remove todas as linhas do dataGridView
            dataGridView1.Rows.Clear();

            //Remover a seleçao do dataGrid View
            dataGridView1.ClearSelection();

            //Percorrer cada um dos enderecos adicionado uma nova  linha na tabela
            for(var i = 0;i< enderecos.Count;i++)
            {
                //Obter endereco percorrido
                var endereco = enderecos[i];

                //Cria uma nova linha no dta GridView com os Daods referentes ao endereco

                dataGridView1.Rows.Add(new object[]
                {
                    endereco.Codigo,
                    endereco.EnderecoCompleto,
                    endereco.Cep,
                    "" //endereco.Paciente.Nome
                });
            }
        }
    }
}
