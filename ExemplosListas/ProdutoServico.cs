namespace ExemplosListas
{
    internal class ProdutoServico
    {
        private List<Produto> produtos = new List<Produto>();

        public void Adicionar(string nome, double precoUnitario, ProdutoLocalizacao localizacao, int quantidade)
        {
            //instanciar um objeto da classe Produto
            Produto produto = new Produto();

            //Atribuir valor para as Propriedades com os dados passados como parametro
            produto.Nome = nome;
            produto.PrecoUnitario = precoUnitario;
            produto.Localizacao = localizacao;
            produto.Quantidade = quantidade;

            //adicionar o produto instanciado na lista de produtos
            produtos.Add(produto);
        }

        public void Editar() { }

        public void Apagar() { }

        public List<Produto> ObterTodos()
        {

            return produtos;
        }

        public Produto ObterPorCodigo()
        {
            return null;
        }
    }
}
