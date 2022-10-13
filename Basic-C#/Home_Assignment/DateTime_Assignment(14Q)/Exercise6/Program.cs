using System;

namespace Exercise6;

class Program 
{
    public static void Main(string[] args)
    {
        DateTime obj = new DateTime();
        System.Console.Write("Enter the date in format (dd/MM/yyyy): ");
        obj = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy",null);

        DateTime obj2 = new DateTime();
        obj2 = obj.AddDays(40);

        System.Console.WriteLine($"The day of the week is {obj2.DayOfWeek}");
    }
}