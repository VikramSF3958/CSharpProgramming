using System;

namespace SwitchStatementAssignment;

class Program
{

    public static void Main(string[] args)
    {
        System.Console.Write("Enter Value1: ");
        int Value1 = Convert.ToInt32(Console.ReadLine());

        System.Console.Write("Enter Value2: ");
        int Value2 = Convert.ToInt32(Console.ReadLine());

        System.Console.WriteLine("Choose your choice of operations: ");
        System.Console.Write(" '+' , '-' , '*' , '/' , '%' : ");
        char choice = Convert.ToChar(Console.ReadLine());

        switch(choice)
        {
            case '+':
            {
                int sum = Value1 + Value2;
                Console.WriteLine($"Result after adding : {sum}");
                break;
            }

            case '-':
            {
                int subtract =  Value1 - Value2;
                System.Console.WriteLine($"Result after subtracting: {subtract}");
                break;
            }

            case '*':
            {
                int multiply = Value1 * Value2;
                System.Console.WriteLine($"Result after multiplying: {multiply}");
                break;
            }

            case '/':
            {
                double divide = (double)Value1 / Value2;
                System.Console.WriteLine($"Result after dividing: {divide}");
                break;
            }

            case '%':
            {
                int mod = Value1 % Value2;
                System.Console.WriteLine($"Result after Modulus: {mod}");
                break;
            }

            default:
            {
                System.Console.WriteLine("Invalid Operation");
                break;
            }
        }


    }
}