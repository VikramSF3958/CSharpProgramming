using System;

namespace Exercise2;

class Program 
{
    public static void Main(string[] args)
    {   
        int number = 0, sum = 0;
        double Average = 0;

        System.Console.Write("Enter 10 numbers: ");
        for(int i=1; i<=10; i++)
        {
            number = Convert.ToInt32(Console.ReadLine());
            sum += number;
        }
        System.Console.WriteLine($"Sum: {sum}");
        Average = (double)sum/10;
        System.Console.Write($"Average: {Average}");
    }
}