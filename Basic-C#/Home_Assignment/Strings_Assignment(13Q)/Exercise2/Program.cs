using System;

namespace Exercise2;

class Program 
{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter the String: ");
        string content = Console.ReadLine();

        int len = content.Length;

        char[] array = new char[len];

       for(int i=0; i<len; i++)
       {
        array[i] = content[i];
       }

       System.Console.Write("The Characters  in the string are: ");
       for(int i=0; i<len; i++)
       {
        System.Console.Write($"{array[i]} ");
       }

    }
}