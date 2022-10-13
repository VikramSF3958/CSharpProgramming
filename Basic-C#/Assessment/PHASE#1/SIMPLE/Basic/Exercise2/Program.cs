using System;

namespace Exercise2;

class Program 
{
    public static void Main(string[] args)
    {   
         double pi = 3.142857142857143;
        System.Console.Write("Radius: ");
        double radius = Convert.ToDouble(Console.ReadLine());
        

        double area = pi * radius * radius;
        System.Console.WriteLine($"Area: {area}");

        double perimeter = 2 * pi * radius;
        System.Console.WriteLine($"Perimeter: {perimeter}");
    }
}