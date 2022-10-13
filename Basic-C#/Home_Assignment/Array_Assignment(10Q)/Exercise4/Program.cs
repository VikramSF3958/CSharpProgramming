using System;

namespace Exercise4;

class Program 
{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter the Size of the Array: ");
        int size = Convert.ToInt32(Console.ReadLine());

        System.Console.WriteLine("Enter the Array Elements: ");

        int[] numbers = new int[size];

        for(int i=0; i<size; i++)
        {
            System.Console.Write($" Element - {i}: ");
            int elements = Convert.ToInt32(Console.ReadLine());
            numbers[i] = elements;
        }

        System.Console.WriteLine();
        System.Console.WriteLine("The Elements are: ");
        for(int i=0; i<size; i++)
        {
            System.Console.WriteLine($"{numbers[i]}");
        }

        System.Console.WriteLine();
        int max = numbers[0];
        for(int i=1; i<size; i++)
        {
            if(numbers[i] > max)
            {
                max = numbers[i];
            }
        }
        System.Console.WriteLine($"MAXIMUM Element in the Array is '{max}'");

        System.Console.WriteLine();
        int min = numbers[0];
        for(int i=1; i<size; i++)
        {
            if(numbers[i] < min)
            {
                min = numbers[i];
            }
        }
        System.Console.WriteLine($"MINIMUM Element in the Array is '{min}'");




    }
}