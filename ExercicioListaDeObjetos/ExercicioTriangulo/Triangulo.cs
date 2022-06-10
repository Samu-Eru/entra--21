namespace ExercicioListaDeObjetos.ExercicioTriangulo
{
    internal class Triangulo
    {
        public double lado1;
        public double lado2;
        public double lado3;
        public int codigo;

        public bool ValidarTriangulo()
        {
            
            if((lado1 + lado2)>lado3)
            {
                return true;
            }
            else
            {

            return false;
            }
            
        }
    }
}
