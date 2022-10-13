using System;

namespace Exercise2;

class Program 
{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter the number of terms: ");
        int terms = Convert.ToInt32(Console.ReadLine());

        int cube = 0;

        for(int i = 1; i<=terms; i++)
        {
            cube = i*i*i;
            System.Console.WriteLine($"Number is {i}: And the cube of the number is: {cube}");
        }
    }
}