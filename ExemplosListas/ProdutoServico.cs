namespace ExemplosListas
{
    internal class ProdutoServico
    {
        private List<Produto> produtos = new List<Produto>();


        // Armazenar o códgio=go do próximo produto 
        private int codigoAtual = 1;
        public void Adicionar(string nome, double precoUnitario, ProdutoLocalizacao localizacao, int quantidade)
        {
            //instanciar um objeto da classe Produto
            Produto produto = new Produto();

            //Atribuir valor para as Propriedades com os dados passados como parametro
            produto.Nome = nome;
            produto.PrecoUnitario = precoUnitario;
            produto.Localizacao = localizacao;
            produto.Quantidade = quantidade;

            //atribuir o código novo para o objeto do produto
            produto.Codigo = codigoAtual;

            //Adicionar 1 no códigp atual para quando criar um novo produto o produto contar outro codigo
            codigoAtual = codigoAtual + 1;

            //adicionar o produto instanciado na lista de produtos
            produtos.Add(produto);
        }

        public bool Editar(int codigoParaAlterar, string nome, double precoUnitario, ProdutoLocalizacao localizacao, int quantidade)
        {
            //Obtém  o produto desejado da lista de produto
            Produto produtoParaAlterar = ObterPorCodigo(codigoParaAlterar);

            //Verifica senão foi possivel encontrar o produto
            if (produtoParaAlterar == null)
            {
                // Retorna falso pq não existe produto com o código dos parâmetros
                return false;
            }
            // Atualiza as propriedades (campos) do produto desejado
            produtoParaAlterar.Nome = nome;
            produtoParaAlterar.Localizacao = localizacao;
            produtoParaAlterar.PrecoUnitario = precoUnitario;
            produtoParaAlterar.Quantidade = quantidade;

            // Retona verdadeiro pq foi possivel alterar o produto
            return true;
        }

        public bool Apagar(int codigo)
        {

            for (int i = 0; i < produtos.Count; i++)
            {
                //Rresgatando de uma lista de tipo primitvo
                //int numero = numeros[i]

                //Resgatando de uma lista de objetos
                Produto produto = produtos[i];

                if (produto.Codigo == codigo)
                {
                    //posso rempover com o indoce do objeto desejado
                    //Produtos.RemoveAT(i)

                    //Posso remover com o objeto desejado
                    produtos.Remove(produto);

                    //Retorna verdadeiro porque o produto com o código desejado foi removido da lista
                    return true;
                }

            }
            // retorna falso porque não foi encontarado com o código desejado, ou seja, nenhum elemento
            return false;
        }

        public List<Produto> ObterTodos()
        {

            return produtos;
        }

        public Produto ObterPorCodigo(int codigo)
        {

            // Percorrer todos os elementos para encontrar o produto
            // Filtrnado por código

            for (int i = 0; i < produtos.Count; i++)
            {
                // Obter o produto da listas de produtos em determinado indice
                var produtoAtual = produtos[i];

                // Verifica se o produto atualda lista percorrida é o desejado
                if (produtoAtual.Codigo == codigo)
                {
                    //Retorna o produto encontrado
                    return produtoAtual;
                }
            }

            //Retona null, caso não encontrado um produto com o código passado como parâmetro
            return null;
        }
    }
}
