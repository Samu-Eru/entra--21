using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioListaDeObjetos.ExercicioAluno
{
    internal class Aluno
    {
        public string Nome;
        public int Matricula;
        public int Idade;
        public string MateriaFavorita;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public double CalcularMedia()
        {
            var media = (Nota1 + Nota2 + Nota3) / 3.0;
            return media;
        }

        public AlunoStatus ObterStatus()
        {
            if (CalcularMedia() >= 7.0)
            {
                return AlunoStatus.Aprovado;
            }
            else if ((CalcularMedia() < 7.0) && (CalcularMedia() >= 5.0))
            {
                return AlunoStatus.EmExame;
            }       
            else
            {
                return AlunoStatus.Reprovado;
            }
        }
       
    }
}
