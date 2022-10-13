using System;

namespace Exercise7;

class Program 
{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter the string: ");
        string content = Console.ReadLine();
        int consonant_count = 0;
        int vowel_count = 0;

        for(int i=0; i<content.Length; i++)
        {
           if( content[i] == 'a' || content[i] == 'e' || content[i] == 'i' || content[i] == 'o' || content[i] == 'u' )
           {
            vowel_count++;
           }
           else
           {
            consonant_count++;
           }
        }

        System.Console.WriteLine($"Total number of consonant in the string: {consonant_count}");
        System.Console.WriteLine($"Total number of vowel in the string: {vowel_count}");
    }
}