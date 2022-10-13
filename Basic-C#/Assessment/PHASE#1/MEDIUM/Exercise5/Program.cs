using System;

namespace Exercise5;

class Program 
{
    public static void Main(string[] args)
    {
        
       System.Console.WriteLine("Enter the limit: ");
       int limit = Convert.ToInt32(Console.ReadLine());

       for(int year = 1; year<=limit; year++)
       {
         if( (year%4==0 && year%100!=0) || (year%400==0))
        {
            System.Console.Write($"{year} ");
        }
       }
    }
}