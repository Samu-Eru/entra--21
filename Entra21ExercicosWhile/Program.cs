using Entra21ExercicosWhile;

Console.WriteLine(@"-------------------MENU-------------------
1 - EXERCICIO 01
2 - EXERCICIO 02
3 - EXERCICIO 03
4 - EXERCICIO 04
5 - EXERCICIO 05
6 - EXERCICIO 06
7 - EXERCICIO 07
8 - EXERCICIO 08");

Console.Write("Digite a opção desejada: ");
int opcaoDesejada = Convert.ToInt32(Console.ReadLine());

if (opcaoDesejada == 1 )
{
    Exercicio01 Exercicio01 = new Exercicio01();
    Exercicio01.Executar();

}
else if (opcaoDesejada == 2)
{
    Exercicio02 Exercicio02 = new Exercicio02();
    Exercicio02.Executar();
}
else if (opcaoDesejada == 3)
{
    Exercicio03 Exercicio03 = new Exercicio03();
    Exercicio03.Executar();
}
else if (opcaoDesejada == 4)
{
    Exercicio04 Exercicio04 = new Exercicio04();
    Exercicio04.Executar();
}
else if (opcaoDesejada == 5)
{
    Exercicio05 Exercicio05 = new Exercicio05();
    Exercicio05.Executar();
}
else if (opcaoDesejada == 6)
{
    Exercicio06 Exercicio06 = new Exercicio06();
    Exercicio06.Executar();
}
else if (opcaoDesejada == 7)
{
    Exercicio07 Exercicio07 = new Exercicio07();
    Exercicio07.Executar();
}
else if (opcaoDesejada == 8)
{
    Exercicio08 Exercicio08 = new Exercicio08();
    Exercicio08.Executar();
}