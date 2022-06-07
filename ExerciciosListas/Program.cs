//Console.Write(@"-------Menu-----
//1 - Exercicio 01");
//var escolha = Convert.ToInt32(Console.ReadLine());
//if(escolha == 1)
//{

//}
//Exercicio a,b,c
List<string> melhoresFilmes = new List<string>();
melhoresFilmes.Add("Dragon ball Evolution");
melhoresFilmes.Add("Titanic");
melhoresFilmes.Add("Lanterna Verde");


//Exercicio d
Console.WriteLine(@$"[0]: {melhoresFilmes[0]}
[1]: {melhoresFilmes[1]}
[2]: {melhoresFilmes[2]}");
Console.WriteLine("-----------------------");

//Exercicio e
melhoresFilmes.Add("");


//Exercicio f
var indiceNomeFilme = melhoresFilmes.IndexOf("Dragon ball Evolution");
melhoresFilmes[indiceNomeFilme] = "Dragon Ball Super: Broly";


//Exercicio g

melhoresFilmes.Remove("Lanterna Verde");

//Exercicio h 
if (melhoresFilmes.Contains("Lanterna Verde"))
{
    Console.WriteLine("O filme 'Lanterna Verde' existe na lista");
}
else
{
    Console.WriteLine("O filme 'Lanterna Verde' não existe na lista");
}


//Exercicio i
melhoresFilmes.Add("Quarteto fantástico");

//Exercicio j
Console.WriteLine(@$"[0]: {melhoresFilmes[0]}
[1]: {melhoresFilmes[1]}
[2]: {melhoresFilmes[2]}
[3]: {melhoresFilmes[3]}");
Console.WriteLine("-----------------------");

//Exercicio k
indiceNomeFilme = melhoresFilmes.IndexOf("Titanic");
melhoresFilmes[indiceNomeFilme] = "Titanic 2";

//Exercicio l
Console.WriteLine(@$"[0]: {melhoresFilmes[0]}
[1]: {melhoresFilmes[1]}
[2]: {melhoresFilmes[2]}
[3]: {melhoresFilmes[3]}");
Console.WriteLine("-----------------------");

//Exercicio m 
if(melhoresFilmes.Contains("A Lagoa Azul"))
{
    Console.WriteLine(" O filme 'A Lagoa Azul' Existe na lista");
}
else
{
    Console.WriteLine("O filme 'A Lagoa Azul' não existe na lista");
}
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("");

//Exercicio02

//Exercicio a
List<string> conteudos = new List<string>();
conteudos.Add("Como fazer um bolo");

//Exerciciio b
Console.Write("[0]: " + conteudos[0]);

//Exercicio c 
var indiceNomeConteudos = conteudos.IndexOf("Como fazer um bolo");
conteudos[indiceNomeConteudos]= "Algoritmos aonde vivem? do que se alimentam";

//Exercicio d
conteudos.Add ("Variáveis");

//Exercicio e
conteudos.Add ("Mais pra frente");

//Exercicio f
indiceNomeConteudos=conteudos.IndexOf("Mais pra frente");
conteudos[indiceNomeConteudos] = "if com E";

//Exercicio g
conteudos.Add("If com OU");

//Exercicio h
conteudos.Add("While");

//Exercicio i
conteudos.Add("For");

//Exercicio j
Console.Write(@$"[0]: {conteudos[0]}
[1]: {conteudos[1]}
[2]: {conteudos[2]}
[3]: {conteudos[3]}
[4]: { conteudos[4]}
[5]: { conteudos[5]}");

//Exercicio k
conteudos.Add("Vetor");

//Exercicio l
conteudos.Add("Vetor");


//Exercicio m
conteudos.Remove("Vetor");
conteudos.Remove("Vetor");

//Exercicio n
conteudos.Add("Vetor");

//Exercicio o
indiceNomeConteudos = conteudos.IndexOf("Vetor");
conteudos[indiceNomeConteudos] = "Vetor com For um amor na minha vida";

//Exercicio p
Console.WriteLine(@$"[0]: {conteudos[0]}
[1]: {conteudos[1]}
[2]: {conteudos[2]}
[3]: {conteudos[3]}
[4]: {conteudos[4]}
[5]: {conteudos[5]}
[6]: {conteudos[6]}");

//Exercicio q
conteudos.Add("Classe propriedades e métodos");

//Exercicio r 
Console.WriteLine(@$"[0]: {conteudos[0]}
[1]: {conteudos[1]}
[2]: {conteudos[2]}
[3]: {conteudos[3]}
[4]: {conteudos[4]}
[5]: {conteudos[5]}
[6]: {conteudos[6]}
[7]: {conteudos[7]}");


//Exercicios 03

//Exercicio a

List<double> notas = new List<double>();
Console.Write("Digite a 1° nota: ");
notas.Add(Convert.ToDouble(Console.ReadLine()));
//Exercicio b
Console.Write("Digite a 2° nota: ");
notas.Add(Convert.ToDouble(Console.ReadLine()));

//Exercicio c
Console.Write("Digite a 3° nota: ");
notas.Add(Convert.ToDouble(Console.ReadLine()));

//Exercicio d
Console.WriteLine($"notas: {notas[0]}, {notas[1]}, {notas[2]}");

//Exercicio e
var media = (notas[0] + notas[1] + notas[2]) / 3;

Console.WriteLine("Média: " + media);


//Exercicio f
if(media >=7.0)
{
    Console.WriteLine("Aprovado");

}
else if(media>=5.0)
{
    Console.WriteLine("Recuperação!");
}
else
{
    Console.WriteLine("Reprovado!!!");
}