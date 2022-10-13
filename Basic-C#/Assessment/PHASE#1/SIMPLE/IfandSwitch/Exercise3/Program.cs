using System;

namespace Exercise3;

class Program 
{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter the speed: ");
        double speed = Convert.ToDouble(Console.ReadLine());

        if(speed <= 10)
        {
            System.Console.WriteLine("Slow");
        }
        else
        {
            if(speed > 10 && speed <= 50)
            {
                System.Console.WriteLine("Average");
            }
            else
            {
                if(speed > 50 && speed <= 150)
                {
                    System.Console.WriteLine("Fast");
                }
                else
                {
                    if(speed > 150 && speed <= 1000)
                    {
                        System.Console.WriteLine("UltraFast");
                    }
                    else
                    {
                        System.Console.WriteLine("Extremely Fast");
                    }
                }
            }
        }
    }
}