using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21ExercicosWhile
{
    internal class Exercicio05
    {
        public void Executar()
        {
            int quantidadeCarros = 0;
            int indice = 1;
            double valorCarro = 0;
            int anoCarro = 0;
            double mediaAnoCarros = 0;
            double mediaValorCarros = 0;
            int comecaComG = 0;
            int comecacomA = 0;

            Console.Write("Quantidade de carros a serem cadastrados: ");
            quantidadeCarros = Convert.ToInt32(Console.ReadLine());


            while (indice <= quantidadeCarros)
            {
                Console.Write("Modelo:");
                string modelo = Console.ReadLine();
                Console.Write("Valor do carro: ");
                valorCarro = Convert.ToDouble(Console.ReadLine());
                mediaValorCarros = mediaValorCarros + valorCarro;
                Console.Write("Ano do carro: ");
                anoCarro = Convert.ToInt32(Console.ReadLine());
                mediaAnoCarros = mediaAnoCarros + anoCarro;
                Console.WriteLine(indice);
                indice = indice + 1;
                if (modelo.StartsWith("G"))
                {
                    comecaComG = comecaComG + 1;
                }
                if (modelo.StartsWith("A"))
                {

                    comecacomA = comecacomA + 1;
                }

            }
            Console.WriteLine("média do ano dos carros: " + (mediaAnoCarros / quantidadeCarros));
            Console.WriteLine("média valor dos carros: " + (mediaValorCarros / quantidadeCarros));
            Console.WriteLine("Quantidade de carros que começam com G: " + comecaComG);
            Console.WriteLine("Quantidade carros que começam com A: " + comecacomA);


        }
    }
}
