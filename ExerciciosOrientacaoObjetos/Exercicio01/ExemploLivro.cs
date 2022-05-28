using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosOrientacaoObjetos.Exercicio01
{
    public class ExemploLivro
    {
        public void Executar()
        {
            Livro livro1 = new Livro();
            Console.Write("Digite o título do Livro: ");
            livro1.Titulo = Console.ReadLine();
            Console.Write("Digite o nome do autor: ");
            livro1.Autor = Console.ReadLine();
            Console.Write("Digite quantas páginas esse livro possui ");
            livro1.QuantidadePaginas = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite quantas páginas você leu desse livro: ");
            livro1.QuantidadePaginasLidas = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite quantas vezes você já leu esse livro: ");
            livro1.QuantidadeReleituras = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite a data de lançamento desse livro: ");
            livro1.DataLancamento = Convert.ToDateTime(Console.ReadLine());
            
            Console.WriteLine("");
            
            livro1.ApresentarTituloAutor();
            Console.WriteLine(@$"Quantidade restantes de páginas para serem lidas: " + livro1.PaginasParaLer() +
                "\nQuantidade páginas lidas no total: " + livro1.TotalPaginasLidas()+
                "\nAnos após publicação: "+livro1.CalcularQuantidadeAnosAposPublicacao());
                

        }
    }
}
