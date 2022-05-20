using ExerciciosVetores;

Console.WriteLine(@"----------------MENU----------------
1 - Exercicio 01
2 - Exercicio 02
3 - Exercicio 03
4 - Exercicio 04
5 - Exercicio 05
6 - Exercicio 06
7 - Exercicio 07");

var opcaoValida = false;
while (opcaoValida == false)
{
    try
    {
        int escolha = Convert.ToInt32(Console.ReadLine());
        if (escolha == 1)
        {
            Exercicio01 Exercicio01 = new Exercicio01();
            Exercicio01.Executar();
            opcaoValida = true;
        }
        else if (escolha == 2)
        {
            Exercicio02 Exercicio02 = new Exercicio02();
            Exercicio02.Executar();
            opcaoValida = true;
        }
        else if (escolha == 3)
        {
            Exercicio03 Exercicio03 = new Exercicio03();
            Exercicio03.Executar();
            opcaoValida = true;
        }
        else if (escolha == 4)
        {
            Exercicio04 Exercicio04 = new Exercicio04();
            Exercicio04.Executar();
            opcaoValida = true;
        }
        else if (escolha == 5)
        {
            Exercicio05 Exercicio05 = new Exercicio05();
            Exercicio05.Executar();
            opcaoValida = true;
        }
        else if (escolha == 6)
        {
            Exercicio06 Exercicio06 = new Exercicio06();
            Exercicio06.Executar();
            opcaoValida = true;
        }
        else if (escolha == 7)
        {
            Exercicio07 Exercicio07 = new Exercicio07();
            Exercicio07.Executar();
            opcaoValida = true;
        }
        else
        {
            Console.WriteLine("Opção inválida!");
            opcaoValida = false;
        }
    }
    catch(Exception ex)
    {
        Console.WriteLine("Valor inválido");
        
    }
}
    
