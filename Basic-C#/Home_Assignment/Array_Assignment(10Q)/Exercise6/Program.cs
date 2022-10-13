using System;

namespace Exercise6;

class Program 
{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter the Size of Elements: ");
        int size = Convert.ToInt32(Console.ReadLine());

        int[] numbers = new int[size];
        System.Console.WriteLine("Enter the elements for array: ");

        for(int i=0; i<size; i++)
        {
            System.Console.Write($"Element - {i}: ");
            int elements = Convert.ToInt32(Console.ReadLine());
            numbers[i] = elements;
        }

        System.Console.WriteLine();
        System.Console.Write("Array Elements are: ");
        for(int i=0; i<size; i++)
        {
            System.Console.Write($" {numbers[i]}");
        }

        int temp = 0;

        for(int i=0; i<size; ++i)
        {
            for(int j = i+1; j<size; ++j)
            {
                if(numbers[i] > numbers[j])
                {
                    temp = numbers[i];
                    numbers[i] = numbers[j];
                    numbers[j] = temp;
                }
            }
        }

        System.Console.WriteLine();
        System.Console.Write("Sorted Array: ");
        for(int i=0; i<size; i++)
        {
            System.Console.Write($" {numbers[i]}");
        }
    }
}