using System;

namespace Exercise5;

class Program 
{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter Array Size:  ");
        int size = Convert.ToInt32(Console.ReadLine());

        int[] numbers = new int[size];

        System.Console.WriteLine("Enter the Elements: ");
        for(int i=0; i<size; i++)
        {
            System.Console.Write($"Elements - {i}: ");
            int elements = Convert.ToInt32(Console.ReadLine());

            numbers[i] = elements;
        }

        System.Console.WriteLine();
        System.Console.WriteLine("The Elements in the Array are: ");
        for(int i=0; i<size; i++)
        {
            System.Console.WriteLine($"{numbers[i]}");
        }

        int new_size = size/2 + 1;
        int[] oddNumbers = new int[new_size];
        int[] evenNumbers = new int[new_size];

        int count=0, count1=0;

        for(int i=0; i<size; i++)
        {
            if(numbers[i]%2==0)
            {
                evenNumbers[count] = numbers[i];
                count++;
            }else
            {
                oddNumbers[count1] = numbers[i];
                count1++;
            }
        }

        System.Console.WriteLine();
        System.Console.WriteLine("Odd Array elements are: ");
        for(int i=0; i<count1; i++)
        {
            System.Console.Write($"{oddNumbers[i]} ");
        }

        System.Console.WriteLine();
        System.Console.WriteLine("Even Array elements are: ");
        for(int i=0; i<count; i++)
        {
            System.Console.Write($"{evenNumbers[i]} ");
        }




    }
}