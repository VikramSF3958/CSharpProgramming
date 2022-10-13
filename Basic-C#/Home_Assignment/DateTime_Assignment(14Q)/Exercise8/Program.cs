using System;

namespace Exercise8;

class Program 
{
    public static void Main(string[] args)
    {   
        DateTime obj;
        System.Console.Write("Enter 1st date");
        System.Console.Write("Enter the date in format (yyyy/MM/dd): ");
        obj = DateTime.ParseExact(Console.ReadLine(), "yyyy/MM/dd", null);

        System.Console.WriteLine($"Before current year: {obj.AddYears(-1).Date}");
        System.Console.WriteLine($"After current year: {obj.AddYears(1).Date}");
    }
}