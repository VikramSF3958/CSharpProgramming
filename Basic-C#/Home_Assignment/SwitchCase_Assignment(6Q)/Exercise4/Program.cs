using System;

namespace Exercise4;

class Program 
{
    public static void Main(string[] args)
    {
    
        System.Console.Write("Enter the 1st integer: ");
        int firstNumber = Convert.ToInt32(Console.ReadLine());

        System.Console.Write("Enter the 2nd integer: ");
        int secondNumber = Convert.ToInt32(Console.ReadLine());

        System.Console.WriteLine("Operation options: \n1.Addition\t 2.Subtraction\t3.Multiplication\t4.Division\t5.Exit");
        System.Console.Write("Enter your choice: ");
        int choice = Convert.ToInt32(Console.ReadLine());

        switch(choice)
        {
            case 1:
            {   
                int sum = firstNumber + secondNumber;
                System.Console.Write($"The addition of {firstNumber} and {secondNumber}: {sum}");
                break;
            }

            case 2:
            {
                int Subtraction = firstNumber - secondNumber;
                System.Console.Write($"The subtraction of {firstNumber} and {secondNumber}: {Subtraction}");
                break;
            }

            case 3:
            {
                int multi = firstNumber * secondNumber;
                System.Console.Write($"The Multiplication of {firstNumber} and {secondNumber}: {multi}");
                break;
            }
            case 4:
            {
                double division = (double)firstNumber/secondNumber;
                System.Console.Write($"The division of {firstNumber} and {secondNumber}: {division}");
                break;
            }

            case 5:
            {
                break;
            }

            default:
            {
                System.Console.WriteLine("Enter a valid Number");
                break;
            }
        }


    }
}