using System;

namespace Exercise1;

class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine(" for calculating X^Y");
        System.Console.Write("Enter base value (i.e., 'X'): ");
        int baseValue = Convert.ToInt32(Console.ReadLine());

        System.Console.Write("Enter power value (i.e., 'Y): ");
        int powerValue = Convert.ToInt32(Console.ReadLine());

        int resultValue = 1;
        for(int i=0; i<powerValue; i++)
        {
            resultValue *=baseValue;
        }

        System.Console.WriteLine($"{baseValue}^{powerValue} is {resultValue}");
    }
}