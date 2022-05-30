using ExerciciosOrientacaoObjetos.Exercicio01;
using ExerciciosOrientacaoObjetos.Exercicio02;

Console.WriteLine(@"-------Menu-------
1 - Exercicio 01 (Livro)
2 - Exercicio 02 (conversão temperatura)");
var escolha = Convert.ToInt32(Console.ReadLine());

if(escolha == 1)
{
     ExemploLivro exercicio01 = new ExemploLivro();
    exercicio01.Executar();
}
else if (escolha == 2)
{
    Temperatura exercicio02 = new Temperatura();
    exercicio02.IdentificarTemperaturaOrigem();
}