using ExerciciosForTryCatch;

Console.WriteLine(@"1 - Exercicio 1
2 - Exercicio 2

");

int escolha = Convert.ToInt32(Console.ReadLine());
if (escolha == 1)
{
    Exercicio1 Exercicio1 = new Exercicio1();
    Exercicio1.Executar();
}
else if (escolha == 2)
{
    Exercicio5 Exercicio5 = new Exercicio5();
    Exercicio5.Executar();
}