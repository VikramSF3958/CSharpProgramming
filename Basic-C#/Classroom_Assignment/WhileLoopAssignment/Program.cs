using System;

namespace WhileLoopAssignment;

class Program 
{
    public static void Main(string[] args)
    {   
        int i = 0;
        while(i<=25)
        {
            if(i%2==0)
            {
                System.Console.WriteLine(i);
            }
            i++;
        }

        System.Console.WriteLine();

        string number = " ";
        int k = 0;

        System.Console.Write("Enter the Number: ");
        number = Console.ReadLine();

        while( !(int.TryParse(number, out k)) )
        {   
            System.Console.WriteLine("Invalid input format. Please enter the input in number format");
            System.Console.Write("Enter the Number Again: ");
            number = Console.ReadLine();
        }
        System.Console.WriteLine($"Number is: {k}");

       
    }
}