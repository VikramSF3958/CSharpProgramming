using System;

namespace Exercise4;

class Program 
{
    public static void Main(string[] args)
    {   
        System.Console.Write("Enter the total terms: ");
        int term = Convert.ToInt32(Console.ReadLine());
        Fibonacci(term, 0, 1);

        void Fibonacci(int terms, int firstNumber, int  secondNumber)
        {
            System.Console.Write(firstNumber + " ");
            int temp = 0, initial = 1;

            while(initial<terms)
            {
                System.Console.Write($"{secondNumber} ");
                temp = firstNumber;
                firstNumber = secondNumber;
                secondNumber = temp +  secondNumber;
                initial++;
            }
        }
    }
}