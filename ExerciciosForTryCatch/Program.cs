﻿using ExerciciosForTryCatch;


var opcaoValida = false;
while (opcaoValida == false)
    try
    {
        Console.WriteLine(@"1 - Exercicio 1
2 - Exercicio 5
3 - Exercicio 8
4 - Exercicio 10
5 - Exercicio 12
6 - Exercicio 13
7 - Exercicio 17
99 - SAIR
");
        var escolha = Convert.ToInt32(Console.ReadLine());

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
        else if (escolha == 3)
        {
            Exercicio8 Exercicio8 = new Exercicio8();
            Exercicio8.Executar();
        }
        else if(escolha == 4)
        {
            Exercicio10 Exercicio10 = new Exercicio10();
            Exercicio10.Executar();
        }
        else if(escolha == 5)
        {
            Exercicio12 Exercicio = new Exercicio12();
            Exercicio.Executar();
        }
        else if (escolha == 99)
        {
            opcaoValida = true;
        }
        else if(escolha == 7)
        {
            Exercicio17 Exercicio17 = new Exercicio17();
            Exercicio17.Executar();
        }
        else if(escolha == 6)
        {
            Exercicio13 Exercicio13 = new Exercicio13();
            Exercicio13.Executar();
        }


        else
        {
            Console.WriteLine("Opcão inválida!");
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine("Valor digitado inválido!");
    }
