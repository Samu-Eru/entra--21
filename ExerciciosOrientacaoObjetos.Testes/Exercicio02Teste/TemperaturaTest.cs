using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExerciciosOrientacaoObjetos.Exercicio02;
using FluentAssertions;
using Xunit;

namespace ExerciciosOrientacaoObjetosTestes.Exercicio02Teste
{
    public class TemperaturaTest
    {
        [Theory]
        [InlineData(0, 32)]
        [InlineData(37, 98.60000000000001)]
        [InlineData(15, 59)]
        [InlineData(92, 197.6)]
        [InlineData(356, 672.8000000000001)]


        public void Validar_Celcius_Para_Farenheit(double valorEntrada, double resultado)
        {
            //Arrange
            var temperaturateste = new Temperatura();
            temperaturateste.TemperaturaValor = valorEntrada;

            //Act
            var temperaturaDestino = valorEntrada*1.8+32;

            //Assert
            temperaturaDestino.Should().Be(resultado);

        }

        [Theory]
        [InlineData(0, 32)]
        [InlineData(37, 98.60000000000001)]
        [InlineData(15, 59)]
        [InlineData(92, 197.6)]
        [InlineData(356, 672.8000000000001)]
        public void Validar_Celcius_Para_Kelvin(double valorEntrada, double resultado)
        {
            //Arrange
            var temperaturateste = new Temperatura();
            temperaturateste.TemperaturaValor = valorEntrada;

            //Act
            var temperaturaDestino = valorEntrada * 1.8 + 32;

            //Assert
            temperaturaDestino.Should().Be(resultado);

        }
    }
}
