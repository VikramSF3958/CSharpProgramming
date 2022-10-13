using System;

namespace Exercise8;

class Program 
{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter a string with number: ");
        string numberString = Console.ReadLine();

        int length = numberString.Length;

        string rawNumber = "";

        for(int i=0; i<length; i++)
        {
            if(char.IsDigit(numberString[i]))
            {
                rawNumber += numberString[i];
            }
        }

        System.Console.WriteLine($"The number presented in the string: {rawNumber}");
        int newNumber = Convert.ToInt32(rawNumber);
    

        if(newNumber % 2 == 0)
        {
            System.Console.WriteLine($"The number is EVEN");
        }
        else
        {
            System.Console.WriteLine($"The number is ODD");
        }
    }
}