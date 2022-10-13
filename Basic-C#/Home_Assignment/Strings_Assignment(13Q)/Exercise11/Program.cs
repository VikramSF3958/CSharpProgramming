using System;

namespace Exercise11;

class Program 
{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter the String: ");
        string content = Console.ReadLine();

        char[] new_content = new char[content.Length];

        int index = 0;

        for(int i=0; i<content.Length; i++)
        {   
            int j;
            for(j=0; j<i; j++)
            {
                if(content[i] == content[j])
                {
                    break;
                }
            }

            if(j==i)
            {
                new_content[index++] = content[i];
            }
        }

        System.Console.WriteLine(new_content);

   
    }
}