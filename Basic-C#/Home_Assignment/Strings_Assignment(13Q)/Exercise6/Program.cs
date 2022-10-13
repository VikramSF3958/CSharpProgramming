using System;

namespace Exercise6;

class Program 
{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter the string: ");
        string content = Console.ReadLine();
        int alphabet_count = 0;
        int digit_count = 0;
        int special_character = 0;

        for(int i=0; i<content.Length; i++)
        {
            if( (content[i] >= 65 && content[i] <= 90) || (content[i] >= 97 && content[i] <=122) )
            {
                alphabet_count++;
            }else
            {
            if( (content[i] >= 48 && content[i] <= 57 ) )
            {
                digit_count++;
            }
            else
            {
                special_character++;
            }
            }
        }

        System.Console.WriteLine($"Total number of alphabets in the string: {alphabet_count}");
        System.Console.WriteLine($"Total number of numbers in the string: {digit_count}");
        System.Console.WriteLine($"Total number of special characters in the string: {special_character}");

    }
}