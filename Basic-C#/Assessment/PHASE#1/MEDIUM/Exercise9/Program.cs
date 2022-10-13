using System;

namespace Exercise9;

class Program 
{
    public static void Main(string[] args)
    {   
        
        int count = 3;
        int star_count = 1;
        
        for(int i=1; i<=4; i++)
        {   
            int temp = count;
            while(temp > 0)
            {
                System.Console.Write(" ");
                temp--;
            }
            int temp2 = star_count;
            for( int k = 1; k<=i;k++)
            {
                while(temp2 > 0)
                {
                    System.Console.Write("*");
                    temp2--;
                }
            }
            System.Console.WriteLine();
            count--;
            star_count += 2;
        }
    }
}