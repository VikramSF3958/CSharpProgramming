using System;

namespace Exercise7;

class Program 
{
    public static void Main(string[] args)
    {
        DateTime date1 ,date2;

        System.Console.Write("Enter 1st date");
        System.Console.Write("Enter the date in format (yyyy/MM/dd): ");
        date1 = DateTime.ParseExact(Console.ReadLine(), "yyyy/MM/dd", null);

        System.Console.Write("Enter 2nd date");
        System.Console.Write("Enter the date in format (yyyy/MM/dd): ");
        date2 = DateTime.ParseExact(Console.ReadLine(), "yyyy/MM/dd", null);

        
        if(date1 > date2)
        {
            System.Console.WriteLine($"{date1} is earlier than {date2}");
        }
        else
        {
            System.Console.WriteLine($"{date2} is earlier than {date1}");
        }
        
    }
}