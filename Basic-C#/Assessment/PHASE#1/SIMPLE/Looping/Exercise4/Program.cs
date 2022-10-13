using System;

namespace Exercise4;

class Program 
{
    public static void Main(string[] args)
    {
        for(int i=1; i<=6; i++)
        {   
            System.Console.WriteLine();
            for(int j=0; j<i; j++)
            {
                System.Console.Write(i);
            }
        }
    }
}