using System;

namespace Exercise2;

class Program 
{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter the Day in number: ");
        int day = Convert.ToInt32(Console.ReadLine());

        System.Console.Write("The Day is: ");
        switch(day)
        {
            case 1:
            {
                System.Console.Write("Monday");
                break;
            }
            
            case 2:
            {
                System.Console.Write("Tuesday");
                break;
            }

            case 3:
            {
                System.Console.Write("Wednesday");
                break;
            }

            case 4:
            {
                System.Console.Write("Thursday");
                break;
            }

            case 5:
            {
                System.Console.Write("Friday");
                break;
            }

            case 6:
            {
                System.Console.Write("Saturday");
                break;
            }

            case 7:
            {
                System.Console.Write("Sunday");
                break;
            }

            default:
            {
                System.Console.Write("Enter Valid Day number");
                break;
            }
        }
    }
}