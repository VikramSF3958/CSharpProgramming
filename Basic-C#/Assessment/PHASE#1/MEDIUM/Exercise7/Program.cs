using System;

namespace Exercise7;

class Program 
{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter starting number: ");
        int startingNumber = Convert.ToInt32(Console.ReadLine());

        System.Console.Write("Enter the difference in Arithmetic Progression: ");
        int differenceInAP = Convert.ToInt32(Console.ReadLine());

        System.Console.Write("Enter the terms of series of AP: ");
        int terms = Convert.ToInt32(Console.ReadLine());

        System.Console.Write("Arithmetic Progression Series: ");
        System.Console.Write($" {startingNumber}");
        int series = startingNumber;
        int sum = startingNumber;

        for(int i=0; i<terms-1; i++)
        {
            series += differenceInAP;
            int AP = series;

            sum +=AP;
            System.Console.Write($" {series}");
        }
        System.Console.WriteLine();
        System.Console.WriteLine($"Sum of AP: {sum}");
    }
}