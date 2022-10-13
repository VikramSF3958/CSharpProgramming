using System;

namespace Exercise10;

class Program 
{
    public static void Main(string[] args)
    {
        for(int i=1; i<=6; i++)
        {
            for(int j=1; j<=18; j++)
            {   
                if(i==1 || i==6)
                {
                    System.Console.Write("*");
                }
                else
                {
                    if(j==1 || j==18)
                    {
                        System.Console.Write("*");
                    }
                    else
                    {
                        System.Console.Write(" ");
                    }
                }
            }
            System.Console.WriteLine();
        }
    }
}