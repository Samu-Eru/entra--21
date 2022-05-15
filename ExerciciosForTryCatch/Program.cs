using ExerciciosForTryCatch;

Console.WriteLine(@"1 - Exercicio 1

");

int escolha = Convert.ToInt32(Console.ReadLine());
if (escolha == 1)
{
    Exercicio1 Exercicio1 = new Exercicio1();
    Exercicio1.Executar();
}