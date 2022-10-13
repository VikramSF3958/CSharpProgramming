using System;

namespace Exercise5;

class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("1.India\n2.Pakistan\n3.Bangladesh");
        System.Console.Write("Enter your choice: ");
        int choice = Convert.ToInt32(Console.ReadLine());

        switch(choice)
        {
            case 1:
            {
                System.Console.WriteLine("1.Gambir\n2.Ashwin\n3.Dhoni\n4.Jadeja");
                break;
            }

            case 2:
            {
                System.Console.WriteLine("1.Babar\n2.Afridi\n3.Nawaz\n4.Rizwan");
                break;
            }

            case 3:
            {
                System.Console.WriteLine("1.Rahman\n2.Ahmed\n3.Rahman\n4.Al Hasan");
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