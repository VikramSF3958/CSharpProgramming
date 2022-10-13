using System;

namespace Exercise2;

class Program 
{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter total terms: ");
        int terms = Convert.ToInt32(Console.ReadLine());

        int firstNumber = 0, secondNumber = 1, initialCount = 1;

        System.Console.Write(firstNumber);

        while(initialCount < terms)
        {
            System.Console.Write($" {secondNumber}");
            int temp = firstNumber;
            firstNumber = secondNumber;
            secondNumber = temp + secondNumber;
            initialCount++;
        }
    }
}