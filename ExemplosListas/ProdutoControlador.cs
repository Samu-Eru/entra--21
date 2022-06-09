using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemplosListas
{
    internal class ProdutoControlador
    {
        private ProdutoServico produtoServico = new ProdutoServico();
        public void GerenciarMenu()
        {
            Cadastrar();
            ApresentarProdutos();
            Cadastrar();
            ApresentarProdutos();
        }


        private void Cadastrar()
        {
            Console.WriteLine("Nome:");
            var nome = Console.ReadLine();

            Console.WriteLine("Qunatidade: ");
            var quantidade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Preço unitário: ");
            var precoUnitario = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Localização: ");
            var localizacao = Console.ReadLine();

            var localizacaoProduto = ObterLocalizacaoProduto(localizacao);

            produtoServico.Adicionar(nome, precoUnitario, localizacaoProduto, quantidade);
        }


        private ProdutoLocalizacao ObterLocalizacaoProduto(string localizacao)
        {
            if(localizacao.ToLower() == "armazem")
            {
                return ProdutoLocalizacao.Armazem;
            }
            else if(localizacao.ToLower() == "Loja")
            {
                return ProdutoLocalizacao.Loja;
            }
            else
            {
                return ProdutoLocalizacao.AreaVenda;
            }
        }


        private void ApresentarProdutos()
        {
            var produtos = produtoServico.ObterTodos();

            for (var i=0; i<produtos.Count; i++)
            {
                var produtoAtual = produtos[i];

                Console.WriteLine("Nome: "+ produtoAtual.Nome  +"Preço unitário: "+produtoAtual.PrecoUnitario);

            }
        }
    }
}
