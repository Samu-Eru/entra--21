﻿namespace ExercicioListaDeObjetos.ExercicioTriangulo
{
    internal class TrianguloServico
    {
        private List<Triangulo> triangulos = new List<Triangulo>();

        private int codigoAtual = 1;

        public void AdicionarTriangulo(int lado1, int lado2, int lado3)
        {
            Triangulo triangulo = new Triangulo();

            triangulo.Lado1 = lado1;
            triangulo.Lado2 = lado2;
            triangulo.Lado3 = lado3;
            triangulo.Codigo = codigoAtual;
            codigoAtual++;

            triangulos.Add(triangulo);

        }

        public bool EditarTriangulo(int codigoParaAlterar, int lado1, int lado2, int lado3)
        {
            Triangulo trianguloParaAlterar = ObterPorCodigo(codigoParaAlterar);

            if(codigoParaAlterar == null)
            {
                return false;
            }
            trianguloParaAlterar.Lado1 = lado1;
            trianguloParaAlterar.Lado2 = lado2;
            trianguloParaAlterar.Lado3 = lado3;

            return true;
        }
        public Triangulo ObterPorCodigo(int codigo)
        {
            for(int i = 0;i< triangulos.Count;i++)
            {
                Triangulo codigoAtual = triangulos[i];

                if(codigoAtual.Codigo == codigo)
                {
                    return codigoAtual;
                }
            }

            return null; 
        }

        public bool EditarTriangulo(int codigoParaAlterar, int lado1, int lado2)
        {
            return true;
        }


        public List<Triangulo> ObterTodos()
        {
            return triangulos;
        }

        //public Triangulo ObterPorCodigo(int codigo)
        //{

        //    return;
        //}
    }
}
