using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosOrientacaoObjetos.Exercicio01
{
    public class Livro
    {
        public string Titulo;
        public string Autor;
        public string CódigoISBN;
        public string IdiomaOriginal;
        public DateTime DataLancamento;
        public int QuantidadePaginas;
        public int QuantidadePaginasLidas;
        public int QuantidadeReleituras;

        public void ApresentarTituloAutor()
        {
            Console.WriteLine("Nome Título: " + Titulo);
            Console.WriteLine("Nome Autor: " + Autor);
        }

        public int PaginasParaLer()
        {
            var totalDePaginas = QuantidadePaginas;
            var paginasLidas = QuantidadePaginasLidas;

            return (QuantidadePaginas - QuantidadePaginasLidas);
        }

        public int TotalVezesLidas()
        {
            var vezesLidas = QuantidadeReleituras;
            return vezesLidas;
        }

        public int TotalPaginasLidas()
        {

            var paginasLidas = QuantidadePaginasLidas;
            var vezesLidas = TotalVezesLidas();
            var quantidadePaginas = QuantidadePaginas;

            if ((vezesLidas > 0))
            {

                return paginasLidas + (quantidadePaginas * vezesLidas);
            }
            
                return paginasLidas;
        }
    
        public int CalcularQuantidadeAnosAposPublicacao()
        {
            var dataAtual = DateTime.Now;


            var tempoPublicado = dataAtual.Year - DataLancamento.Year;

            return tempoPublicado;
        }
    }
}
