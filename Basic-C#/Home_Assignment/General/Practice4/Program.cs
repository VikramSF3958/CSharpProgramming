using System;

namespace Practice4;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Radius: ");
        int radius = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter height: ");
        int height = Convert.ToInt32(Console.ReadLine());

        double volume = 3.14d * radius * radius * height;

        Console.WriteLine($"Volume: {volume}");
    }
}