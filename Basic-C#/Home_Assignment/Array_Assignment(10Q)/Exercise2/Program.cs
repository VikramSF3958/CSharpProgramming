using System;

namespace Exercise1;

class Program 
{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter size of the array: ");
        int size = Convert.ToInt32(Console.ReadLine());

        int[] numbers = new int[size]; 

        System.Console.WriteLine("Enter the Elements of the Array:  ");
        for(int i=size-1; i>=0; i--)
        {
            int element = Convert.ToInt32(Console.ReadLine());
            numbers[i] = element;
        }

        System.Console.WriteLine();
        System.Console.WriteLine("<---- ELEMENTS in ARRAY ---->");
        System.Console.Write("Elements in the Array are: ");
        for(int i=0; i<size; i++)
        {
            System.Console.Write($"{numbers[i]} ");
        }
    }
}