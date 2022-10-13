using System;

namespace Exercise7;

class Program 
{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter the size of Array: ");
        int size = Convert.ToInt32(Console.ReadLine());

        int[ , ] numbers = new int[size, size]; 

        System.Console.WriteLine("Enter the Array Elements: ");
        for(int i=0; i<size; i++)
        {
            for(int j=0; j<size; j++)
            {
                System.Console.Write($"Element - [{i}][{j}]: ");
                int element = Convert.ToInt32(Console.ReadLine());
                numbers[i, j] = element;
            }
        }

        System.Console.WriteLine();
        System.Console.WriteLine("The Martix is: ");
        for(int i=0; i<size; i++)
        {
            for(int j=0; j<size; j++)
            {
                System.Console.Write($"{numbers[i, j]} ");
            }
            System.Console.WriteLine();
        }

    }
}