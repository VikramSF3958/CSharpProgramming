using System;

namespace Exercise1; 

class Program 
{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter the String: ");
        string content = Console.ReadLine();

        int count = 0;

        foreach(var text in content)
        {
            count++;
        }

        System.Console.Write($"The length of the String: {count}");
    }
}