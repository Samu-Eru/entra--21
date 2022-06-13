namespace ExemplosListas
{
    internal class ProdutoServico
    {
        private List<Produto> produtos = new List<Produto>();


        // Armazenar o código do próximo produto 
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
                Produto produtoAtual = produtos[i];

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
        public Produto ObterMenorPrecoUnitario()
        {
            double menorPrecoUnitario = double.MaxValue;
            Produto produtoMenorPRecoUnitario = null;

            //percorrer a lista de produtos para obter o produto com o menor preço unitario
            for (int i = 0; i < produtos.Count; i++)
            {
                //obtem o produto atual posui o menor preço unitátio
                Produto produto = produtos[i];

                if (produto.PrecoUnitario < menorPrecoUnitario)
                {
                    //armazena o preço unitário , pois é o menor preço unitário até o momento
                    menorPrecoUnitario = produto.PrecoUnitario;
                     
                    //armazena o produto para posteriormente saber qual é o produto com om menor preçp unitário
                    produtoMenorPRecoUnitario = produto;
                }
            }
            //
            return produtoMenorPRecoUnitario;
        }

        public List<double> ObterTodosPrecos()
        {
            
            //cria uma lista de preço
            var precos = new List<double>();
            // precorre todos os produtos
            for (int i = 0; i < produtos.Count; i++)
            {
                //obtem os produto atual da lista de produto
                var produto = produtos[i];
                //adiciona o preço total na lisra de precos
                precos.Add(produto.CalcularPrecoTotal());
            }
            return precos;
        }

        public List<double> ObterPrecosTotais(ProdutoLocalizacao localizacao)
        {
            var precos = new List<double>();

            for (int i = 0; i < produtos.Count; i++)
            {
                var produto = produtos[i];
            }
            return precos;
        }

        public List<double> ObterPrecosTotaisFiltrandoPorLocalizacao (ProdutoLocalizacao localizacao)
        {
            // criar umas listas de precos totais
            var precos = new List<double>();
            //percorre todos os produtos
            for (int i = 0; i<produtos.Count;i++)
            {
                //obtem o produto atual da lista de produtos
                var produto = produtos[i];

                //verifica se a localizao do produto atual é a localizacao passada np parametro
                if(produto.Localizacao == localizacao)
                {
                    //adicona o preço total do preoduto atual que foi filtrado por localizacao
                    precos.Add(produto.CalcularPrecoTotal());
                }
            }
            return precos;
        }
        public List<double> ObterPrecosTotaisDoArmazem()
        {
            //colar uma lista de precos totais
            var precos = new List<double>();

            // percorre todos os produtos
            for (int i = 0; i < produtos.Count; i++)
            {
                //obtém o profuto atual da lista de produtos
                var produto = produtos[i];

                //verifca se a localizacao do produto atual é Armazem 
                if(produto.Localizacao == ProdutoLocalizacao.Armazem)
                {
                    //Adiciona o preço total do produto atual que foi filtrado por armazem 
                    precos.Add(produto.CalcularPrecoTotal());
                }
            }
            return precos;
        }

        public double ObterMediaPrecosTotais()
        {
            var somaPrecosTotais = 0.0;
            //Percorre todos os produtos
            for(int i = 0; i<produtos.Count;i++)
            {
               // Obtém o produto atual da lista de produtos
                var produto = produtos[i];

                //Adiciona o preço total do produto na variável soma de preços totais
                somaPrecosTotais += produto.CalcularPrecoTotal();

            }
            // calcula a media de acordo com aquantidade de produtos
            var media = somaPrecosTotais / produtos.Count;

            return media;
        }
    }
}
