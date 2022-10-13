using System; 

namespace Exercise1;

class Program 
{
    public static void Main(string[] args)
    {   
        System.Console.WriteLine("INCHES ----> CM");
        System.Console.Write("Enter a number: ");
        double number = Convert.ToDouble(Console.ReadLine());

        System.Console.WriteLine($"{number} to centimeters is {2.54 * number}cm ");
    }
}