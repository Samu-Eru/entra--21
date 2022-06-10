namespace ExemplosListas
{
    internal class ProdutoControlador
    {
        private ProdutoServico produtoServico = new ProdutoServico();
        public void GerenciarMenu()
        {
            Console.Clear();
            int codigo = 0;
            //repete enquanto o codigo não for o menu sair(6)
            while (codigo != 6)
            {
                //Apresenta o menu e solicita o código
                codigo = ApresentarSolicitarMenu();

                Console.Clear();

                if (codigo == 1)
                {
                    //Menu esvolhido´para listar produtos
                    ApresentarProdutos();
                }
                else if (codigo == 2)
                {
                    //Menu escolhido para cadastrar produto
                    Cadastrar();
                }
                else if (codigo == 3)
                {
                    //Menu escolhido para editar produto
                    Editar();
                }
                else if (codigo == 4)
                {
                    //Menu escolhido para apagar produto
                    Apagar();
                }
                else if (codigo == 5)
                {
                    ApresentarProduto();

                }

                Console.WriteLine("Aperte alguma tecla para continuar: ");
                Console.ReadKey();

            }
        }
        private void ApresentarProduto()
        {
            ApresentarProdutos();

            Console.WriteLine("Digite o código do produto a ser detalahdo: ");
            int codigo = Convert.ToInt32(Console.ReadLine());

            var produto = produtoServico.ObterPorCodigo(codigo);


            if (produto == null)
            {

                Console.WriteLine("Produto não cadastrado!");

                return;
            }

            Console.Clear();
            Console.WriteLine(@$"Código  {produto.Codigo}
Nome: {produto.Nome} 
Preço unitário: {produto.PrecoUnitario}
Quantidade: {produto.Quantidade}
Total: {produto.CalcularPrecoTotal()}");
        }

        private void Apagar()
        {
            ApresentarProdutos();

            Console.Write("Digite o códdigo desejado: ");
            int codigo = Convert.ToInt32(Console.ReadLine());

            var registroApagado = produtoServico.Apagar(codigo);

            Console.WriteLine(registroApagado == true
                ? "Registro removido com sucesso"
                : "Nenhum produto cadastrado com o código informado! ");
        }
        private void Editar()
        {
            ApresentarProdutos();

            Console.WriteLine("Códigp produto desejado: ");
            var codigo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nome: ");
            var nome = Console.ReadLine();

            Console.WriteLine("Quantidade:");
            var quantidade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Preço unitário: ");
            var precoUnitario = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(@"Localização disponível
- Armazem
- Area Venda
- Loja");

            Console.WriteLine("Localização: ");
            var localizacao = Console.ReadLine();

            var localizacaoProduto = ObterLocalizacaoProduto(localizacao);

            var alterou = produtoServico.Editar(codigo, nome, precoUnitario, localizacaoProduto, quantidade);

            if (alterou == false)
            {
                Console.WriteLine("Código digitado não existe!");

            }
            else
            {
                Console.WriteLine("Produto alterado com sucesso!");
            }
        }
        private int ApresentarSolicitarMenu()
        {
            Console.WriteLine(@"Menu
1 - Listar todos
2 - Cadastar
3 - Editar
4 - Apagar
5 - Apresentar produto desejado
6 Sair");

            int codigo = SolicitarCodigo();

            return codigo;
        }

        private int SolicitarCodigo()
        {
            int codigo = 0;
            // Continua soliciatando o código até que seja um código entre 1 e 6
            while (codigo < 1 || codigo > 6)
            {
                try
                {
                    Console.Write("Digite o código> ");
                    codigo = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Digite um menu válido");
                }
            }
            return codigo;
        }
        private void Cadastrar()
        {
            Console.WriteLine("Nome:");
            var nome = Console.ReadLine();

            Console.WriteLine("Quantidade: ");
            var quantidade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Preço unitário: ");
            var precoUnitario = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(@"Localizações disponíveis: 
- Armazem
- Area Venda
- Loja");
            Console.WriteLine("Localização: ");
            var localizacao = Console.ReadLine();

            var localizacaoProduto = ObterLocalizacaoProduto(localizacao);

            produtoServico.Adicionar(nome, precoUnitario, localizacaoProduto, quantidade);
        }


        private ProdutoLocalizacao ObterLocalizacaoProduto(string localizacao)
        {
            if (localizacao.ToLower() == "armazem")
            {
                return ProdutoLocalizacao.Armazem;
            }
            else if (localizacao.ToLower() == "Loja")
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

            if (produtos.Count == 0)
            {
                Console.WriteLine("Nenhum produto cadastrado :( ");
                //Para a execução deste método
                return;
            }

            for (var i = 0; i < produtos.Count; i++)
            {
                var produtoAtual = produtos[i];

                Console.WriteLine("\nCódigo: " + produtoAtual.Codigo +
                                  "\nNome: " + produtoAtual.Nome + "\n");

            }
        }
    }
}
