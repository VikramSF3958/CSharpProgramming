using System;

namespace Exercise6;

class Program 
{
    public static void Main(string[] args)
    {   
        System.Console.Write("Enter radius: ");
        int radius = Convert.ToInt32(Console.ReadLine());

        System.Console.WriteLine("1.Area\n2.Perimeter\n3.Diameter");
        System.Console.Write("Enter your choice: ");
        int choice = Convert.ToInt32(Console.ReadLine());

        switch(choice)
        {
            case 1:
            {
                double area = (double)3.14 * radius * radius;
                System.Console.Write($"Area of circle: {area}");
                break;
            }
        

            case 2:
            {
                double perimeter = 2 * (double)3.14 * radius;
                System.Console.Write($"Perimeter of circle: {perimeter}");
                break;
            }

            case 3:
            {
                double diameter = 2 * radius;
                System.Console.Write($"Diameter of circle: {diameter}");
                break;
            }

            default:
            {
                System.Console.WriteLine("Invalid Input");
                break;
            }

        }

    }
}