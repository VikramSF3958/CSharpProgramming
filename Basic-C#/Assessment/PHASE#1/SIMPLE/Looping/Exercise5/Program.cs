using System;

namespace Exercise5;

class Program 
{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter the number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int flag = 0;
        for(int i=2; i<number; i++)
        {
            if(number%i==0)
            {
                flag = 1;
                break;
            }
        }

        if(flag == 1)
        {
            System.Console.WriteLine("It is not a prime");
        }
        else
        {
            System.Console.WriteLine("It is prime");
        }
    }
}