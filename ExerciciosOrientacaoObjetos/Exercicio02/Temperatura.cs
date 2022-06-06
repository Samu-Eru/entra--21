using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosOrientacaoObjetos.Exercicio02
{
    public class Temperatura
    {
        public string TemperaturaOrigem;
        public string TemperaturaDestino;
        public double TemperaturaValor;

        public void IdentificarTemperaturaOrigem()
        {
            var i = 1;
            while (TemperaturaValor >= 0)
            {

                    Console.WriteLine(i);
                try
                {
                    Console.Write(@"Temperatura de Origem: ");
                    TemperaturaOrigem = Console.ReadLine().Trim().ToLower();
                    Console.Write("Temperatura de Destino: ");
                    TemperaturaDestino = Console.ReadLine().Trim().ToLower();
                    Console.Write("Temperatura Valor: ");
                    TemperaturaValor = Convert.ToInt32(Console.ReadLine());


                    if ((TemperaturaOrigem == "celcius" || TemperaturaOrigem == "c") && (TemperaturaDestino == "kelvin" || TemperaturaDestino == "k"))
                    {
                        Console.WriteLine(CalcularCelciusParaKelvin());
                    }

                    else if ((TemperaturaOrigem == "celcius" || TemperaturaOrigem == "c") && (TemperaturaDestino == "fahrenheit" || TemperaturaDestino == "f"))
                    {
                        Console.WriteLine(CalcularCelciusParaFahrenheit());
                    }

                    else if ((TemperaturaOrigem == "kelvin" || TemperaturaOrigem == "k") && (TemperaturaDestino == "celcius" || TemperaturaDestino == "c"))
                    {
                        Console.WriteLine(CalcularKelvinParaCelcius());
                    }

                    else if ((TemperaturaOrigem == "kelvin" || TemperaturaOrigem == "k") && (TemperaturaDestino == "fahrenheit" || TemperaturaDestino == "f"))
                    {
                        Console.WriteLine(CalcularKelvinParaFahrenheit());
                    }

                    else if ((TemperaturaOrigem == "fahrenheit" || TemperaturaOrigem == "f") && (TemperaturaDestino == "celcius" || TemperaturaDestino == "c"))
                    {
                        Console.WriteLine(CalcularFahrenheitParaCelcius());
                    }

                    else if ((TemperaturaOrigem == "fahrenheit" || TemperaturaOrigem == "f") && (TemperaturaDestino == "kelvin" || TemperaturaDestino == "k"))
                    {
                        Console.WriteLine(CalcularFahrenheitParaKelvin());
                    }

                    i++;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Inválido!");
                }
            }
        }
        
        public string CalcularCelciusParaKelvin()
        {
            return "Temperatura Convertida: "+(TemperaturaValor + 273.15);
        }
        public string CalcularCelciusParaFahrenheit()
        {

            return "Temperatura Convertida: " + ((TemperaturaValor * 1.8) +32);
        }
        
        public string CalcularKelvinParaCelcius()
        {

            return "Temperatura Convertida: " + (TemperaturaValor - 273.15);

        }
        public string CalcularKelvinParaFahrenheit()
        {
            return "Temperatura Convertida: " + ((TemperaturaValor - 32) / 1.8 + 273.15);
        }

        public string CalcularFahrenheitParaCelcius()
    {
        
            return "Temperatura Convertida: " + (TemperaturaValor - 32)/1.8;
       
    }
        public string CalcularFahrenheitParaKelvin()
        {
            return "Temperatura Convertida: " + ((TemperaturaValor /1.8)*(5/9)) + 273.15;
        }

}
}