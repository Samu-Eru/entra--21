using ExerciciosOrientacaoObjetos.Exercicio01;

Console.WriteLine(@"-------Menu-------
1 - Exercicio 01");
var escolha = Convert.ToInt32(Console.ReadLine());

if(escolha == 1)
{
     ExemploLivro primeiro = new ExemploLivro();
    primeiro.Executar();
}