using ExerciciosVetores;

Console.WriteLine(@"----------------MENU----------------
1 - Exercicio 01
2 - Exercicio 02
3 - Exercicio 03");
int escolha = Convert.ToInt32(Console.ReadLine());

if(escolha == 1)
{
    Exercicio01 Exercicio01 = new Exercicio01();
    Exercicio01.Executar();
}
else if(escolha == 2)
{
    Exercicio02 Exercicio02 = new Exercicio02();
    Exercicio02.Executar();
}
else if(escolha == 3)
{

}