using System;

namespace Exercise3;

class Program
{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter Year: ");
        int year = Convert.ToInt32(Console.ReadLine());

        if(year % 4 == 0)
        {
            System.Console.WriteLine("{year} is a leap-year");
        }
    }
}