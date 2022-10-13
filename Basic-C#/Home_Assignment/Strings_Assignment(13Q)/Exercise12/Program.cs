using System;

namespace Exercise12;

class Program 
{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter the string: ");
        string content = Console.ReadLine();
        
        string[] split_content = content.Split(' ');

        int[] arrayNumber = new int[split_content.Length];

        for(int i=0; i<split_content.Length; i++)
        {
            arrayNumber[i] = Convert.ToInt32(split_content[i]);
        }

        int max = arrayNumber[0];

        for(int i=0; i<arrayNumber.Length; i++)
        {
            if(max<arrayNumber[i])
            {
                max = arrayNumber[i];
            }
        }

        int min = arrayNumber[0];

         for(int i=0; i<arrayNumber.Length; i++)
        {
            if(min>arrayNumber[i])
            {
                min = arrayNumber[i];
            }
        }

        System.Console.WriteLine($"The maximum number in the entered string: {max}");
        System.Console.WriteLine($"The minimum number in the entered string: {min}");


    }
}