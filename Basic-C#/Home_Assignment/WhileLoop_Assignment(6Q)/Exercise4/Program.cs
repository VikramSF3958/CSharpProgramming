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

        while( !(int.TryParse(number, out k)) )
        {   
            System.Console.WriteLine("Invalid input.");
            System.Console.Write("Enter the Number Again: ");
            number = Console.ReadLine();
        }
        if( k >= 1 && k <= 5)
        {
            System.Console.WriteLine($"Number is in the Range(1 - 5): {k}");
        }else
        {
            System.Console.WriteLine("Number not is in the Range(1 - 5)");
        }
        

       
    }
}