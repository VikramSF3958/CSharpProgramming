using System;

namespace Exercise4;

class Program 
{
    public static void Main(string[] args)
    {   

        string number = " ";
        int k = 0;

        System.Console.Write("Enter the Number: ");
        number = Console.ReadLine();

        do
        {

            System.Console.WriteLine($"{number}");

            if(!(int.TryParse(number, out k)))
            {
                System.Console.Write("Enter the Number, Again: ");
                number = Console.ReadLine();
            }
            
        }while( !(int.TryParse(number, out k)) );

        if(k >= 1 && k <= 10)
        {
            System.Console.WriteLine($"The number {k} is valid and is in the range(1 - 10)");
        }else
        {
            System.Console.WriteLine($"The number {k} not in the range(1 - 10)");
        }


    }
}