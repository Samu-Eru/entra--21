using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExemplosWindowsForms.Exemplo01
{
    internal class EnderecoServico
    {
        private List<Endereco> enderecos;

        public EnderecoServico()
        {
            enderecos = new List<Endereco> { };

            LerArquivo();
        }

        public void Adicionar(Endereco endereco)
        {
            enderecos.Add(endereco);

            SalvarArquivo();
        }

        public void Editar(Endereco enderecoParaAlterar)
        {
            //Percorre a lista de enderecos aim de encontrar o endereco que deve ser alterado
            for (int i = 0; i < enderecos.Count; i++)
            {
                //obtidp o endereco da lista de enderecos
                var endereco = enderecos[i];
                
                //Vereifica se o código de enderecos´percorrido é o mesmo do endereço que deve ser alterado
                 if(endereco.Codigo == enderecoParaAlterar.Codigo)
                {
                    //Atualizado campos do endereco encontrado
                    endereco.EnderecoCompleto = enderecoParaAlterar.EnderecoCompleto;
                    endereco.Cep = enderecoParaAlterar.Cep;
                    endereco.Paciente = enderecoParaAlterar.Paciente;

                    SalvarArquivo();
                }
            }
        }

        public void Apagar(int codigoParaApagar)
        {
            //Percorre a lista de enderecos aim de encontrar o endereco que deve ser Apagado
            for (int i = 0; i < enderecos.Count;i++)
            {
                //Verifica se o endereco é o desejado percorrendo toda a lista
                var endereco = enderecos[i];

                if(endereco.Codigo == codigoParaApagar)
                {
                    //Remove o endereco encontrado da lista de enderecos
                    enderecos.Remove(endereco);

                    SalvarArquivo();

                    return;
                }
            }
        }
        
        //Método que retorna todos os enderecos
        public List<Endereco> ObtemTodos()
        {
            return enderecos;
        }

        public Endereco ObterPorCodigo(int codigo)
        {
            //Percorre a lista de enderecos aim de encontrar o endereco com o código desejado
            for (int i = 0; i < enderecos.Count; i++)
            {
                //Obtém por endereco percorrido
                var endereco = enderecos[i];

                //verrifica se o endereco contém o código desejado
                if (endereco.Codigo == codigo)
                {
                    return endereco;
                }
            }

            // Retorna  null pois não encontrou o endereco com o código desejado
            return null;
        }

        public void SalvarArquivo()
        {
            var enderecosEmJson = JsonConvert.SerializeObject(enderecos);
            File.WriteAllText("enderecos.json", enderecosEmJson);
        }

        public void LerArquivo()
        {
            //Verificar se o endereco existe
            if(File.Exists("enderecos.json") == false)
                    return;

            //Ler o arquivo Json e converte para uma lista de objetos de enderecos
            var enderecosEmJson = File.ReadAllText("enderecos.json");
            enderecos = JsonConvert.DeserializeObject<List<Endereco>>(enderecosEmJson);
        }
    }
}
