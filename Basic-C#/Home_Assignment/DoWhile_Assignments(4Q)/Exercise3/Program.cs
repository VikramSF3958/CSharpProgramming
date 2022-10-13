using System;

namespace Exercise3;

class Program 
{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter number of terms: ");
        int terms = Convert.ToInt32(Console.ReadLine());

        int firstTerm = 0, secondTerm = 1, temp = 0, initial = 1;

        System.Console.Write($"{firstTerm} ");

        do
        {
            System.Console.Write($"{secondTerm} ");

            temp = firstTerm;
            firstTerm = secondTerm;
            secondTerm  = temp + secondTerm;
            initial++;
        }while(initial<terms);
    }
}