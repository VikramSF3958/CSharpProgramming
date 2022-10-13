using System;

namespace Exercise5;

class Program 
{
    public static void Main(string[] args)
    {   
        System.Console.Write("Number of terms: ");
        int terms = Convert.ToInt32(Console.ReadLine());

        int sum=0;
        System.Console.Write("The odd numbers: ");
        System.Console.WriteLine("The odd natural numbers are: ");

        for(int i=1; i<=10;i++ )
        {   
            System.Console.WriteLine("{0} ", 2*i-1);
            sum += 2*i-1;
        }

        System.Console.WriteLine($"The sum of {terms} odd natural numbers: {sum}");
    }
}