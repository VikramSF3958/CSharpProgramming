using System;

namespace Exercise6;

class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        System.Console.WriteLine($"Factorial of {number} is {factorial(number)}");

        int factorial(int number)
        {
            int factNumber = 1;
            while(number>0)
            {
                factNumber *= number;
                number--;
            }
            return factNumber;
        
        }


    }

    
}