namespace ExercicioListaDeObjetos.ExercicioAluno
{
    internal class AlunoServico
    {
        private List<Aluno> alunos = new List<Aluno>();
        public bool AdicionarAluno(string nome, int idade, string materiaFavorita, int codigoMatricula, double nota1, double nota2, double nota3)
        {
            bool alunoJaExiste = ObterAlunoPorMatricula(codigoMatricula);
            if (alunoJaExiste == true)
            {
                return false;
            }

            Aluno aluno = new Aluno();
            aluno.Nome = nome;
            aluno.Idade = idade;
            aluno.MateriaFavorita = materiaFavorita;
            aluno.Matricula = codigoMatricula;
            aluno.Nota1 = nota1;
            aluno.Nota2 = nota2;
            aluno.Nota3 = nota3;
            alunos.Add(aluno);
            return true;
        }
        public bool ApagarAluno(string nome)
        {
            var alunoJaExiste = AlunoExistePorNome(nome);
            if (alunoJaExiste == true)
            {

                return false;
            }

            for (int i = 0; i < alunos.Count; i++)
            {
                Aluno nomeAlunoParaDeletar = alunos[i];
                if (nomeAlunoParaDeletar.Nome == nome)
                {
                    alunos.Remove(nomeAlunoParaDeletar);
                }
            }

            return true;


        }

        public bool EditarDadosCadastrais(int matricula, string nome, int idade, string materiaFavorita)
        {
            //VERIFICA SE ALUNO EXISTE, CASO NÃO EXISTA, METODO RETORNA FALSO
            var alunoParaAlterar = ObterAlunoPorMatricula(matricula);
            if (alunoParaAlterar == null)
            {
                return false;
            }

            alunoParaAlterar.Nome = nome;
            alunoParaAlterar.Idade = idade;
            alunoParaAlterar.Matricula = matricula;
            alunoParaAlterar.MateriaFavorita = materiaFavorita;


            return true;

        }

        public bool EditarNotasAluno(int matricula, double nota1, double nota2, double nota3)
        {
            var alunoParaAlterar = ObterAlunoPorMatricula(matricula);
            if (alunoParaAlterar == null)
            {
                return false;
            }
            for (int i = 0; i < alunos.Count; i++)
            {
                alunoParaAlterar = alunos[i];
                if (alunoParaAlterar.Matricula == matricula)
                {
                    alunoParaAlterar.Nota1 = nota1;
                    alunoParaAlterar.Nota2 = nota2;
                    alunoParaAlterar.Nota3 = nota3;
                }
            }
            return true;
        }

        public List<string> ObterTodosOsAlunos()
        {
            List<string> nomes = new List<string>();

            for (int i = 0; i < alunos.Count(); i++)
            {
                Aluno nomeAtual = alunos[i];

                nomes.Add(nomeAtual.Nome);
                    
                
            }
            return nomes;
        }

        public List<double> ObterMedias()
        {

        }

        public bool AlunoExistePorNome(string nome)
        {
            for (int i = 0; i < alunos.Count; i++)
            {
                Aluno alunoAtual = alunos[i];
                if (alunoAtual.Nome == nome)
                {
                    return true;
                }
            }
            return false;
        }

        public Aluno ObterAlunoPorMatricula(int matricula)
        {
            for (int i = 0; i < alunos.Count; i++)
            {
                Aluno alunoAtual = alunos[i];
                if (alunoAtual.Matricula == matricula)
                {
                    return alunoAtual;

                }
            }
            return null;
        }

    }
}
