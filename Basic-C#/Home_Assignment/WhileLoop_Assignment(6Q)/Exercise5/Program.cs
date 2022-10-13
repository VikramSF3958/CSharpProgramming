using System;

namespace Exercise5;

class Program 
{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter a Digit: ");
        int digit = Convert.ToInt32(Console.ReadLine());
        int copyDigit = digit;

        int temp = 0, sum = 0;

        while(digit > 0)
        {
            temp = digit % 10;
            digit = digit / 10;
            sum += temp;
        }

        System.Console.WriteLine($"The sum of digits {copyDigit} is {sum}");
    }
}