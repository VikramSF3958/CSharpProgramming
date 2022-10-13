using System;

namespace Exercise8;

class Program 
{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter the String: ");
        string content = Console.ReadLine();

        System.Console.Write("Position to start Extraction: ");
        int start = Convert.ToInt32(Console.ReadLine());

        System.Console.Write("Input the substring-length: ");
        int length = Convert.ToInt32(Console.ReadLine());

        char[] new_content = new char[length];

        int index = 0;

        for(int i=start; i<content.Length;i++)
        {   
            if(index == length )
            {
                break;
            }
            new_content[index] = content[i];
            index++;
        }

        for(int i=0; i<new_content.Length; i++)
        {
            System.Console.Write($"{new_content[i]} ");
        }

    }
}