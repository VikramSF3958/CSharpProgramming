using System;

namespace Exercise4;

class Program 
{
    public static void Main(string[] args)
    {
        System.Console.Write("Table to be calculated: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int result = 0;
        for(int i=1; i<=10; i++)
        {   
            result = number * i;
            System.Console.WriteLine($"{number} x {i} = {result}");
        }
    }
}