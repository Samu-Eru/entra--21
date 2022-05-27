using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosOrientacaoObjetos
{
    public class Livro
    {
        public string Titulo;
        public string Autor;
        public string CódigoISBN;
        public string IdiomaOriginal;
        public DateTime DataLançamento;
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

            if ((vezesLidas == 0) || (vezesLidas == 1))
            {
                return paginasLidas;
            }
            else
            {
                return paginasLidas + (quantidadePaginas * vezesLidas);
            }

        }
    }
}
