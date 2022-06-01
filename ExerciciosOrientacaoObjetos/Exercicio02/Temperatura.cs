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
        public string TemperaturaDestino;
        public double TemperaturaValor;

        public double IdentificarTemperaturaOrigem()
        {

            var resultadoTemperaturaconvertida = 0.0;


            if ((TemperaturaOrigem == "celcius" || TemperaturaOrigem == "c") && (TemperaturaDestino == "kelvin" || TemperaturaDestino == "k"))
            {
               resultadoTemperaturaconvertida = CalcularCelciusParaKelvin();
            }

            else if ((TemperaturaOrigem == "celcius" || TemperaturaOrigem == "c") && (TemperaturaDestino == "fahrenheit" || TemperaturaDestino == "f"))
            {
                resultadoTemperaturaconvertida = CalcularCelciusParaFahrenheit();
            }

            else if ((TemperaturaOrigem == "kelvin" || TemperaturaOrigem == "k") && (TemperaturaDestino == "celcius" || TemperaturaDestino == "c"))
            {
                resultadoTemperaturaconvertida = CalcularKelvinParaCelcius();
            }

            else if ((TemperaturaOrigem == "kelvin" || TemperaturaOrigem == "k") && (TemperaturaDestino == "fahrenheit" || TemperaturaDestino == "f"))
            {
                resultadoTemperaturaconvertida = CalcularKelvinParaFahrenheit();
            }

            else if ((TemperaturaOrigem == "fahrenheit" || TemperaturaOrigem == "f") && (TemperaturaDestino == "celcius" || TemperaturaDestino == "c"))
            {
                resultadoTemperaturaconvertida = CalcularFahrenheitParaCelcius();
            }

            else if ((TemperaturaOrigem == "fahrenheit" || TemperaturaOrigem == "f") && (TemperaturaDestino == "kelvin" || TemperaturaDestino == "k"))
            {
                resultadoTemperaturaconvertida = CalcularFahrenheitParaKelvin();
            }

            return resultadoTemperaturaconvertida;

        }

        public double CalcularCelciusParaKelvin()
        {
            return TemperaturaValor + 273.15;
        }
        public double CalcularCelciusParaFahrenheit()
        {

            return (TemperaturaValor * 1.8) + 32;
        }

        public double CalcularKelvinParaCelcius()
        {

            return TemperaturaValor - 273.15;

        }
        public double CalcularKelvinParaFahrenheit()
        {
            return (TemperaturaValor - 32) / 1.8 + 273.15;
        }

        public double CalcularFahrenheitParaCelcius()
        {

            return (TemperaturaValor - 32) / 1.8;

        }
        public double CalcularFahrenheitParaKelvin()
        {
            return (TemperaturaValor - 32) / 1.8 + 273.15;
        }

    }
}