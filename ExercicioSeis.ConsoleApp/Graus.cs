using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioSeis.ConsoleApp
{
    internal class Graus
    {
        public double celsius;
        public double fahrenheit;
        public double ConverterCelsiusFahrenheit(double fahrenheit)
        {
            fahrenheit = (celsius * 1.8) + 32;
            return fahrenheit;
        }
    }
}