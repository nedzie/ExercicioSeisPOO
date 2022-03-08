using System;

namespace ExercicioSeis.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Graus celsius = new Graus();
            Console.Write("Informa a temperatura em ºC: \n> ");
            celsius.celsius = double.Parse(Console.ReadLine());
            celsius.fahrenheit = celsius.ConverterCelsiusFahrenheit(celsius.fahrenheit);
            Console.Clear();
            Console.WriteLine(celsius.celsius + "°F, convertidos ficam " + celsius.fahrenheit.ToString("#.##") + "°C.");
            Console.ReadKey();
        }
    }
}