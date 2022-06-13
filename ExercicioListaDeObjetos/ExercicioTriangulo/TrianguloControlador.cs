using ExercicioListaDeObjetos.ExercicioTriangulo;

namespace ExercicioListaDeObjetos
{

    internal class TrianguloControlador
    {
        private TrianguloServico trianguloServico = new TrianguloServico();
        public void GerenciarMenu()
        {
            int codigo = 0;

            while (codigo != 6)
            {

                codigo = ApresentarSolicitarMenu();
                if (codigo == 1)
                {
                    Cadastrar();
                }
                else if (codigo == 2)
                {
                    Editar();
                }
                else if (codigo == 5)
                {
                    ApresentarTrianguloPorCodigo();
                }
                else if (codigo == 4)
                {
                    ApresentarTriangulos();
                }
            }
        }

        private int ApresentarSolicitarMenu()
        {
            Console.WriteLine(@"1 - Criar um novo triangulo
2 - Editar 
3 - Apagar 
4 - Obter todos os registros
5- Obter registro por código");
            int escolha = SolicitarMenu();

            return escolha;
        }

        private int SolicitarMenu()
        {
            int codigo = 0;
            while (codigo < 1 || codigo > 6)
            {
                try
                {
                    Console.Write("Digite o código da opção desejada: ");
                    codigo = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Opção inválida!");
                }
            }
            return codigo;
        }
         private void Editar()
        {
            ApresentarTriangulos();

            Console.WriteLine("Digite o código para ser editado: ");
            var codigo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite um novo valor para o lado um: ");
            var lado1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite um novo valor para o lado dois: ");
            var lado2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite um novo valor para o lado três: ");
            var lado3 = Convert.ToInt32(Console.ReadLine());

            var codigoExiste = trianguloServico.EditarTriangulo(codigo,lado1,lado2,lado3);

            if(codigoExiste == false)
            {
                Console.WriteLine("Código do triangulo não Existe!");
                
            }
            else
            {
                Console.WriteLine("Triângulo alterado com sucesso!");
            }
            



        }
            
        private void Cadastrar()
        {
            Console.Write("Digite o valor do lado 1: ");
            var lado1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o valor do lado 2: ");
            var lado2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o valor do lado3:");
            var lado3 = Convert.ToInt32(Console.ReadLine());

            trianguloServico.AdicionarTriangulo(lado1, lado2, lado3);



        }
        private void ApresentarTriangulos()
        {
            var triangulo = trianguloServico.ObterTodos();

            for (int i = 0; i< triangulo.Count;i++)
            {
                var produtoAtual = triangulo[i];

                Console.WriteLine("Código: "+produtoAtual.Codigo);
                Console.WriteLine("Soma de todos os lados: "+(produtoAtual.Lado1+produtoAtual.Lado2+produtoAtual.Lado3));
                Console.WriteLine("");
            }
        }
        private void ApresentarTrianguloPorCodigo()
        {
            ApresentarTriangulos();

            Console.WriteLine("Digite o código do triangulo a ser detalhado:");
            int codigo = Convert.ToInt32(Console.ReadLine());

            Triangulo trianguloEscolhido = trianguloServico.ObterPorCodigo(codigo);

            if(trianguloEscolhido == null)
            {
                Console.WriteLine("Nenhum cadastro encontrado!");
                return;
            }

            Console.WriteLine(@$"Código: {trianguloEscolhido.Codigo}
Lado1: {trianguloEscolhido.Lado1}
Lado2: {trianguloEscolhido.Lado2}
Lado3: {trianguloEscolhido.Lado3}");
        }


    }
}

