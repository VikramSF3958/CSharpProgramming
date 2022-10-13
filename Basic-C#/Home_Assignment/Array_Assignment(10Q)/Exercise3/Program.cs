using System;

namespace Exercise3;

class Program 
{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter the size of the Array:");
        int size = Convert.ToInt32(Console.ReadLine());

        System.Console.WriteLine();
        System.Console.WriteLine($"Enter {size} elements to the Array:");

        int[] numbers = new int[size];
        int sum = 0;

        for(int i=0; i<size; i++)
        {
            System.Console.Write($"Element - {i}: ");
            int elements = Convert.ToInt32(Console.ReadLine());
            numbers[i] = elements;
            sum += numbers[i];
        }

        System.Console.WriteLine($"The sum of Array Elements: {sum}");


    }
}