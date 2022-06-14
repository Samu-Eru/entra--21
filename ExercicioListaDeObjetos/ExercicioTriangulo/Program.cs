using ExercicioListaDeObjetos;
Console.Write("Digite o código do Exercicio desejado: ");
int escolha = Convert.ToInt32(Console.ReadLine());

if (escolha == 1)
{
    TrianguloControlador controlador = new TrianguloControlador();
    controlador.GerenciarMenu();
}
else if (escolha == 2)
{
    AlunoControlador controlador = new AlunoControlador();
    controlador.GerenciarMenu();
}


