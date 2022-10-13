using System;

namespace DateTimeAssignment;

class Program 
{
    public static void Main(string[] args)
    {
        DateTime obj = new DateTime(2021, 8, 10, 10, 40, 32);

        System.Console.WriteLine($"Year: {obj.Year}");
        System.Console.WriteLine($"Month: {obj.Month}");
        System.Console.WriteLine($"Day: {obj.Day}");
        System.Console.WriteLine($"Hour: {obj.Hour}");
        System.Console.WriteLine($"Minute: {obj.Minute}");
        System.Console.WriteLine($"Seconds: {obj.Second}");


        string dateAndTime = obj.ToString("MM/dd/yyyy hh:mm:ss tt");
        System.Console.WriteLine(dateAndTime);

        string[] sub = dateAndTime.Split('/', ':', ' ');
        System.Console.Write("Reversed Order: ");
        for(int i=sub.Length-1; i>=0; i--)
        {
            System.Console.Write($"{sub[i]} ");
        }

        System.Console.WriteLine();
        System.Console.Write("Enter the Day in format (yyyy/MM/dd HH:mm:ss tt): ");
        DateTime obj1 = DateTime.ParseExact(Console.ReadLine(), "yyyy/MM/dd HH:mm:ss tt", null);

        System.Console.WriteLine($"{obj1.Year}");
        System.Console.WriteLine($"{obj1.Month}");
        System.Console.WriteLine($"{obj1.Day}");
    }
}