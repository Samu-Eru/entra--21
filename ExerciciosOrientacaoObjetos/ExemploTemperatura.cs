using ExerciciosOrientacaoObjetos.Exercicio02;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosOrientacaoObjetos
{
    internal class ExemploTemperatura
    {
        public void Executar()
        {
            Temperatura temperatura = new Temperatura();

            Console.Write(@"Temperatura de Origem: ");
            temperatura.TemperaturaOrigem = Console.ReadLine().Trim().ToLower();
            Console.Write("Temperatura de Destino: ");
            temperatura.TemperaturaDestino = Console.ReadLine().Trim().ToLower();
            Console.Write("Temperatura Valor: ");
            temperatura.TemperaturaValor = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Temperatura convertida: " + temperatura.IdentificarTemperaturaOrigem());
        }
    }
}
