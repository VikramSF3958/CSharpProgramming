using System;
 namespace Exercise7;

 class Program 
 {
    public static void Main(string[] args)
    {
        int spaces = 5;
        int number = 5;

        for(int i=1; i<number; i++)
        {
            for(int j=1; j<spaces; j++)
            {
                System.Console.Write(" ");
            }
            for(int j=1; j<=i; j++)
            {
                System.Console.Write("* ");
            }
            System.Console.WriteLine();
            spaces--;
        }
    }
 }