using System;

namespace MethodsAssignment;

class Program 
{
    public static void Main(string[] args)
    {   
        string action = "";
        System.Console.WriteLine("<-------- ARTHITMEIC OPERATIONS ---------->");

        do
        {
            System.Console.WriteLine("Menu: ");
            System.Console.WriteLine("1.Addition\n2.Subtarction\n3.Multiplication\n4.Division");
            System.Console.Write("Enter your Choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine();

            switch (choice)
            {
                case 1:
                {
                    System.Console.WriteLine(" A D D I T I O N ");
                    System.Console.Write("Enter number-1: ");
                    double number1 = Convert.ToDouble(Console.ReadLine());
                    System.Console.Write("Enter number-2: ");
                    double number2 = Convert.ToDouble(Console.ReadLine());

                    double result = Addition(number1, number2);
                    System.Console.WriteLine($"Result: {result}");
                    break;
                    
                }

                case 2:
                {
                    System.Console.WriteLine(" S U B T R A C T I O N ");
                    System.Console.Write("Enter number-1: ");
                    double number1 = Convert.ToDouble(Console.ReadLine());
                    System.Console.Write("Enter number-2: ");
                    double number2 = Convert.ToDouble(Console.ReadLine());

                    double result = Subtarction(number1, number2);
                    System.Console.WriteLine($"Result: {result}");
                    break;
                }

                case 3:
                {
                    System.Console.WriteLine(" M U L T I P L I C A T I O N ");
                    System.Console.Write("Enter number-1: ");
                    double number1 = Convert.ToDouble(Console.ReadLine());
                    System.Console.Write("Enter number-2: ");
                    double number2 = Convert.ToDouble(Console.ReadLine());

                    double result = Multiplication(number1, number2);
                    System.Console.WriteLine($"Result: {result}");
                    break;
                    
                }

                case 4:
                {
                    System.Console.WriteLine(" D I V I S I O N ");
                    System.Console.Write("Enter number-1: ");
                    double number1 = Convert.ToDouble(Console.ReadLine());
                    System.Console.Write("Enter number-2: ");
                    double number2 = Convert.ToDouble(Console.ReadLine());

                    double result = Division(number1, number2);
                    System.Console.WriteLine($"Result: {result}");
                    break;
                }
                default:
                {
                    System.Console.WriteLine("Enter a valid Input from the choice!! ");
                    break;
                }
            }

            System.Console.Write("Do you want to continue this operation again ?? (yes or no): ");
            action = Console.ReadLine().ToLower();

        }while(action == "yes");

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