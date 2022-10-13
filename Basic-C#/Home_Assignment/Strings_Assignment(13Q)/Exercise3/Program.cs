using System;

namespace Exercise3;

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

       System.Console.Write("The Characters of the string are:  ");
       for(int i=len-1; i>=0; i--)
       {
        System.Console.Write($"{array[i]} ");
       }

    }
}