using System;
 namespace Exercise8;

 class Program 
 {
    public static void Main(string[] args)
    {
        int spaces = 5;
        int number = 5;
        int count = 1;

        for(int i=1; i<number; i++)
        {
            for(int j=1; j<spaces; j++)
            {
                System.Console.Write(" ");
            }
            for(int j=1; j<=i; j++)
            {
                System.Console.Write($"{count} ");
                count++;
            }
            System.Console.WriteLine();
            spaces--;
            
        }
    }
 }