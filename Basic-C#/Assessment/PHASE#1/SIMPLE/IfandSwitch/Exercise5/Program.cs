using System;

namespace Exercise5;

class Program 
{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter a character: ");
        char letter = Convert.ToChar(Console.ReadLine().ToLower());

        if(letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
        {
            System.Console.WriteLine("It is a vowel");
        }
        else
        {
            System.Console.WriteLine("It is not a vowel");
        }
    }
}