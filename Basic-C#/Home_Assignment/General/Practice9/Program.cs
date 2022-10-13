using System;

namespace Practice9;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the Speed in Km/hr: ");
        double speed = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Seconds: ");
        int seconds = Convert.ToInt32(Console.ReadLine());

        int distance = (int)(speed * seconds * (double)5/18);

        Console.WriteLine($"Distance travelled : {distance} meters");
    }
}