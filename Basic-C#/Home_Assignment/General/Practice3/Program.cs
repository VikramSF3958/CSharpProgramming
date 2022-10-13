using System;

namespace Practice3;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the amount of Celsius: ");
        int celsius = Convert.ToInt16(Console.ReadLine());

        int fahrenheit = (celsius * 9/5) + 32;
        Console.WriteLine($"Kelvin: {celsius + 273.15}");
        Console.Write($"Farenheit: {fahrenheit}");
    }
}