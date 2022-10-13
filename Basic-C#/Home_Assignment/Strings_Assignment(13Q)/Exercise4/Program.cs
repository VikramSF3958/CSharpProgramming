using System;

namespace Exercise4;

class Program 
{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter the String: ");
        string content = Console.ReadLine();

        int len = content.Length;
        int count = 0;

        string[] context = content.Split(' ');

        System.Console.Write($"Total words: {context.Length}");
    }
}