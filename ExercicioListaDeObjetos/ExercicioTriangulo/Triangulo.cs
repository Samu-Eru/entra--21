﻿namespace ExercicioListaDeObjetos.ExercicioTriangulo
{
    internal class Triangulo
    {
        public int Lado1;
        public int Lado2;
        public int Lado3;
        public int Codigo;

        public bool ValidarTriangulo()
        {
            
            if((Lado1 + Lado2)>Lado3)
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