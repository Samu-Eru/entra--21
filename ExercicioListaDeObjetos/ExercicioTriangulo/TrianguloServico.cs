using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioListaDeObjetos.ExercicioTriangulo
{
    internal class TrianguloServico
    {
        private List<Triangulo> triangulos = new List<Triangulo>();

        private int codigoAtual = 1;

        public void AdicionarTriangulo(int lado1, int lado2, int lado3)
        {
            Triangulo triangulo = new Triangulo();

            triangulo.lado1 = lado1;
            triangulo.lado2 = lado2;
            triangulo.lado3 = lado3;
            triangulo.codigo = codigoAtual;
            codigoAtual++;

            triangulos.Add(triangulo);

        }

        public bool EditarTriangulo(int codigoParaAlterar, int lado1 ,int lado2)
        {
            Triangulo trianguloParaAlterar = 
            return;
        }

        public List<Triangulo> ObterTodos()
        {
            return triangulos;
        }

        public Triangulo ObterPorCodigo(int codigo)
        {
            return triangulos.codigo;
        }
    }
}
