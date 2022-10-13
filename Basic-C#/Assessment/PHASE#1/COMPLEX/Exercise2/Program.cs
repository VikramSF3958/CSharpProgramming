using System;

namespace Exercise2;

class Program 
{
    public static void Main(string[] args)
    {   

        double sum = 1;

        System.Console.Write($"Taylor Series: 1+");

        for(int i=1; i<=8; i++)
        {
            sum += power(2,i)/factorial(i);
            System.Console.Write($"{2}^{i}/{i}! + ");
        }

        System.Console.WriteLine();
        System.Console.WriteLine($"Sum: {sum}");


        double power(double x, double y)
        {   
            double risePower = 1;
            for(int i=0; i<y; i++)
            {
                risePower *= x;
            }
            return risePower;
        }

        double factorial(double number)
        {   
        double fact =1;
           for(int i=1; i<=number; i++)
           {
            fact *= i;
           }

            return fact;
        }
    }
}