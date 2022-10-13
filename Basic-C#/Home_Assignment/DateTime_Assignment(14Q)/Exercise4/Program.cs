using System;

namespace Exercise4;

class Program 
{
    public static void Main(string[] args)
    {

        DateTime obj = new DateTime();
        System.Console.Write("Enter the date in format (dd/MM/yyyy): ");
        obj = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy",null);

        System.Console.WriteLine($"The day of the week is {obj.DayOfWeek}");
    }
}