using System;

namespace Exercise3;

class Program 
{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter degree in Celcius: ");
        double celsius = Convert.ToInt32(Console.ReadLine());

        double fahrenheit = celsius* ((double)9/5) + 32;

        System.Console.WriteLine($"Fahrenheit: {fahrenheit}");
    }
}