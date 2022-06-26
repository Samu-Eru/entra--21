using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploWindowsForms.Exemplo1
{
    internal class Paciente
    {
        public int Codigo;
        public string Nome;
        public double Altura;
        public double Peso;

        public double ObterImc()
        {
            // Math.Pow => exponencial
            return Peso / Math.Pow(Altura, 2);
        }
    }
}
