using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioConstrutores._04
{
    class Temperatura
    {
        public double Celsius { get; set; }

        public Temperatura( double celsius)
        {
            this.Celsius = celsius;
        }

        public string ConversorUnidade()
        {
            double kelvin = 273.15;
            double fahrenheit = 32;
            double conversorKelvin = Celsius + kelvin;
            double conversorFahrenheit = (Celsius * 9/5)+ fahrenheit;

            string text = $"Temperatura Kelvin: {conversorKelvin}\n" +
                $" Temperatura Fahrenheit: {conversorFahrenheit}";
            return text;
        }
    }
}
