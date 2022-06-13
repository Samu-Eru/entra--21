namespace ExercicioListaDeObjetos.ExercicioTriangulo
{
    internal class Triangulo
    {
        public int Lado1;
        public int Lado2;
        public int Lado3;
        public int Codigo;

        public bool ValidarTriangulo(double lado1, double lado2, double lado3)
        {
            
            if (((lado1 + lado2)>lado3) && ((lado1+lado3)>lado2) && ((lado2+lado3)>lado1))
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
