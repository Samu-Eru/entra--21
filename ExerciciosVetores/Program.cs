using ExerciciosVetores;

Console.WriteLine(@"----------------MENU----------------
1 - Exercicio 01");
int escolha = Convert.ToInt32(Console.ReadLine());

if(escolha == 1)
{
    Exercicio01 Exercicio01 = new Exercicio01();
    Exercicio01.Executar();
}