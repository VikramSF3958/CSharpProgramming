using System;

namespace Exercise3;

class Program 
{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter the Month in number:  ");
        int month = Convert.ToInt32(Console.ReadLine());

    

        switch(month)
        {
            case 1:
            {
                System.Console.Write("Month have 31Days");
                break;
            }

            case 2:
            {
                System.Console.Write("Month have 28Days");
                break;
            }

            case 3:
            {
                System.Console.Write("Month have 31Days");
                break;
            }

            case 4:
            {
                System.Console.Write("Month have 30Days");
                break;
            }
            case 5:
            {
                System.Console.Write("Month have 31Days");
                break;
            }

            case 6:
            {
                System.Console.Write("Month have 30Days");
                break;
            }
            case 7:
            {
                System.Console.Write("Month have 31Days");
                break;
            }

            case 8:
            {
                System.Console.Write("Month have 31Days");
                break;
            }
            case 9:
            {
                System.Console.Write("Month have 30Days");
                break;
            }

            case 10:
            {
                System.Console.Write("Month have 31Days");
                break;
            }
            case 11:
            {
                System.Console.Write("Month have 30Days");
                break;
            }
            case 12:
            {
                System.Console.Write("Month have 31Days");
                break;
            }
            
            
            default:
            {
                System.Console.Write("Enter a valid Month");
                break;
            }
        }
    }
}