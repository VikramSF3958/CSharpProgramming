using System;

namespace Exercise9;

class Program 
{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter the size of Array: ");
        int size = Convert.ToInt32(Console.ReadLine());

        int[ , ] numbers_A = new int[size, size]; 
        int[ , ] numbers_B = new int[size, size]; 
        int[ , ] numbers_C = new int[size, size]; 
        

        System.Console.WriteLine();
        System.Console.WriteLine("Enter the Elements for Array-A: ");
        for(int i=0; i<size; i++)
        {
            for(int j=0; j<size; j++)
            {
                System.Console.Write($"Element - [{i}][{j}]: ");
                int element = Convert.ToInt32(Console.ReadLine());
                numbers_A[i, j] = element;
            }
        }

        System.Console.WriteLine();
        System.Console.WriteLine("Enter the Elements for Array-B: ");
        for(int i=0; i<size; i++)
        {
            for(int j=0; j<size; j++)
            {
                System.Console.Write($"Element - [{i}][{j}]: ");
                int element = Convert.ToInt32(Console.ReadLine());
                numbers_B[i, j] = element;
            }
        }

        System.Console.WriteLine();
        System.Console.WriteLine("<--------- M U L T I P L I C A T I O N ---------> ");
        for(int i=0; i<size; i++)
        {
            for(int j=0; j<size; j++)
            {
                numbers_C[i, j] = 0;
                for(int k=0; k<size; k++)
                {
                    numbers_C[i, j] += numbers_A[i, k] * numbers_B[k, j]; 
                }
            }
        }

        System.Console.WriteLine();
        System.Console.WriteLine("The resultant Martix is: ");
        for(int i=0; i<size; i++)
        {
            for(int j=0; j<size; j++)
            {
                System.Console.Write($"{numbers_C[i, j]} ");
            }
            System.Console.WriteLine();
        }

    }
}