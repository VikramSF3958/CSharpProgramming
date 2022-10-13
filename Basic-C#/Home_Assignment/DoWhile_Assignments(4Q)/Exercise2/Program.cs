using System;

namespace Exercise2;

class Program 
{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter total count of numbers wanted to enter:  ");
        int count = Convert.ToInt32(Console.ReadLine());
        int sum = 0, i=1;

        do
        {
            System.Console.Write($"Enter {i} number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if(number >= 0)
            {
                sum += number;
            }
            i++;
            
        }while(i<=count);

        System.Console.WriteLine($"The Sum is: {sum}");
    }
}