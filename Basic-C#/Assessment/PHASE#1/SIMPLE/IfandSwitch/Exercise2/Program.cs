using System;

namespace Exercise2;

class Program 
{
    public static void Main(string[] args)
    {
        System.Console.Write($"Enter an integer: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if(number < 100)
        {
            System.Console.WriteLine("Less than 100");
        }
        else
        {
            if(number >= 100 && number < 200)
            {
                System.Console.WriteLine("Between 100 and 200");
            }
            else
            {
                System.Console.WriteLine("Greater than 200");
            }
        }
    }
}