using System;

namespace Exercise1;

class Program 
{
    public static void Main(string[] args)
    {   
        System.Console.WriteLine("<-------- CALCULATOR ---------->");

        System.Console.Write("Enter number-1: ");
        double number1 = Convert.ToDouble(Console.ReadLine());
        System.Console.Write("Enter number-2: ");
        double number2 = Convert.ToDouble(Console.ReadLine());

        System.Console.WriteLine("_____________  Available Operations _______________");
        System.Console.WriteLine("1.Addition\n2.Subtarction\n3.Multiplication\n4.Division");
        System.Console.WriteLine();

        double result;
   
        result = Addition(number1, number2);
        System.Console.WriteLine($"Addition: {result}");
                 
        result = Subtarction(number1, number2);
        System.Console.WriteLine($"Subtraction: {result}");
             
        result = Multiplication(number1, number2);
        System.Console.WriteLine($"Multiplication: {result}");
                 
        result = Division(number1, number2);
        System.Console.WriteLine($"Division: {result}");
                 
        double Addition(double value1, double value2)
        {
            return value1 + value2;
        }

        double Subtarction(double value1, double value2)
        {
            return value1 - value2;
        }

        double Multiplication(double value1, double value2)
        {
            return value1 * value2;
        }
        
        double Division(double value1, double value2)
        {
        return value1 / value2;
        }

    }
}