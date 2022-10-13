using System;

namespace Exercise1;

class Program 
{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter the Grade (E, V, G, A, F):  ");
        char grade = Convert.ToChar(Console.ReadLine());

        System.Console.Write("Grade: ");
        switch(grade)
        {
            case 'E':
            {
                System.Console.Write("Excellent");
                break;
            }

            case 'V':
            {
                System.Console.WriteLine("Very Good");
                break;
            } 

            case 'G':
            {
                System.Console.Write("Good");
                break;
            }

            case 'A':
            {
                System.Console.Write("Average");
                break;
            }

            case 'F':
            {
                System.Console.Write("Fail");
                break;
            }

            default:
            {
                System.Console.Write("Invalid Grade");
                break;
            }
        }
    }
}