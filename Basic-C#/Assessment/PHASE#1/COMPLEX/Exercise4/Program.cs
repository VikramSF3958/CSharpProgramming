using System;

namespace Exercise4;

class Program 
{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter the String:");
        string content = Console.ReadLine();
        string rmvDuplicates  = "";

       for(int i=0; i<content.Length;i++)
       {
        if(!rmvDuplicates.Contains(content[i]))
        {
            rmvDuplicates += content[i];
        }
       }

        System.Console.WriteLine(rmvDuplicates);
        
    }
}