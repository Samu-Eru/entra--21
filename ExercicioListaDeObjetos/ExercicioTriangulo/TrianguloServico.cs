namespace ExercicioListaDeObjetos.ExercicioTriangulo
{
    internal class TrianguloServico
    {
        private Triangulo trianguloClasse = new Triangulo();
        private List<Triangulo> triangulos = new List<Triangulo>();

        private int codigoAtual = 1;

        public bool AdicionarTriangulo(int lado1, int lado2, int lado3)
        {
            var trianguloPodeExistir = trianguloClasse.ValidarTriangulo(lado1, lado2, lado3);
            Triangulo triangulo = new Triangulo();

            if (trianguloPodeExistir == true)
            {

                triangulo.Lado1 = lado1;
                triangulo.Lado2 = lado2;
                triangulo.Lado3 = lado3;
                triangulo.Codigo = codigoAtual;

                codigoAtual++;

                triangulos.Add(triangulo);
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool EditarTriangulo(int codigoParaAlterar, int lado1, int lado2, int lado3)
        {
            Triangulo trianguloParaAlterar = ObterPorCodigo(codigoParaAlterar);

            if (trianguloParaAlterar == null)
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
            for (int i = 0; i < triangulos.Count; i++)
            {
                Triangulo codigoAtual = triangulos[i];

                if (codigoAtual.Codigo == codigo)
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

        public bool Apagar(int codigo)
        {
            for (int i = 0; i < triangulos.Count; i++)
            {
                Triangulo trianguloAtual = triangulos[i];

                if (trianguloAtual.Codigo == codigo)
                {
                    triangulos.Remove(trianguloAtual);
                    return true;
                }

            }
            return false;
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
