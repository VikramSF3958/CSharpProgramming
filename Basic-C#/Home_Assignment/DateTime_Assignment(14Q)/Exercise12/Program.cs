using System;

namespace Exercise12;

class Program 
{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter year: ");
        int year = Convert.ToInt32(Console.ReadLine());

        System.Console.Write("Enter Month(in number): ");
        int month = Convert.ToInt32(Console.ReadLine());


        System.Console.WriteLine($"Days: {DateTime.DaysInMonth(year, month)}");

    }
}