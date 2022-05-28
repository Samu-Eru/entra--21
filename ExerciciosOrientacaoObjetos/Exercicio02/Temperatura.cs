using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosOrientacaoObjetos.Exercicio02
{
    internal class Temperatura
    {
        public string TemperaturaOrigem;
        public double TemperaturaDestino;
        public double TemperaturaValor;

        public void IdentificarTemperaturaOrigem()
        {
            Console.Write(@"Opções de converção: 
1 - Calcular Celsius para Kelvin
2 - Calcular Celsius para Fahrenheit
3 - Calcular Kelvin para Celsius
4 - Calcular Kelvin para Fahrenheit
5 - Calcular Fahrenheit para Celsius
6 - Calcular Fahrenheit para Kelvin");
            var opcaoEscolhida = Convert.ToInt32(Console.ReadLine());

            if(opcaoEscolhida == 1)
            {
                CalcularCelciusParaKelvin();
            }
        }
        public double CalcularKelvinParaCelcius()
        {
            
                return TemperaturaValor - 273.15;

            }
            
        public double CalcularFahrenheitParaCelcius()
        {

                return ((TemperaturaValor - 32) / 1.8);
        }

        public double CalcularCelciusParaKelvin()
        {
                return (TemperaturaValor + 273.15);
            
                return ((TemperaturaValor- 32) / 1.8 + 273.15);
            }
            return TemperaturaValor;
        }
         public double CalcularfahrenheitPara
        public double CalcularFahrenheit()  
        {
            var nomeTemperaturaOrigem = TemperaturaOrigem.ToLower();
            if(nomeTemperaturaOrigem.StartsWith("c"))
            {
                return TemperaturaValor * 1.8 + 32;
            }
            else if (nomeTemperaturaOrigem.StartsWith("k"))
            {
                return 1.8 *(TemperaturaValor - 273) + 32;
            }


            return TemperaturaValor;
        }

    }
}