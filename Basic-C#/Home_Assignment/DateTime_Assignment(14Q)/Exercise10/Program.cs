using System;

namespace Exercise10;

class Program 
{
    public static void Main(string[] args)
    {
        DateTime obj = new DateTime();
        obj = DateTime.Now;

        System.Console.WriteLine($"Yesterday: {obj.AddDays(-1).Date}");
        System.Console.WriteLine($"Tommorrow: {obj.AddDays(1).Date}");
    }
}