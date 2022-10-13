using System;

namespace Practice2;

class Program
{
    public static void Main(string[] args)
    {   
        Console.Write("Input the first number: ");
        int firstNumber = Convert.ToInt16(Console.ReadLine());
        Console.Write("Input the second number: ");
        int secondNumber = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine($"{firstNumber} + {secondNumber}  = {firstNumber + secondNumber}");
        Console.WriteLine($"{firstNumber} - {secondNumber}  = {firstNumber - secondNumber}");
        Console.WriteLine($"{firstNumber} x {secondNumber}  = {firstNumber * secondNumber}");
        Console.WriteLine($"{firstNumber} / {secondNumber}  = {firstNumber / secondNumber}");
        Console.WriteLine($"{firstNumber} % {secondNumber}  = {firstNumber % secondNumber}");

        

    }
}