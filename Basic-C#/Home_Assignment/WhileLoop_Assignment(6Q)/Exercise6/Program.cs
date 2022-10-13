using System;

namespace Exercise6;

class Program 
{
    public static void Main(string[] args)
    {   
        int i = 1;

        System.Console.WriteLine("Even Numbers: ");
        while(i<=100)
        {
            if(i%2==0)
            {
                System.Console.Write($" {i}");
            }
            i++;
        }

        System.Console.WriteLine();
        System.Console.WriteLine("Odd Numbers: ");
        i = 0;
        while(i<=100)
        {
            if(i%2==1)
            {
                System.Console.Write($" {i}");
            }
            i++;
        }

        System.Console.WriteLine();
        System.Console.WriteLine("Prime Numbers: ");
        i=1;
        while(i<=100)
        {   
        int temp = i/2, flag=0;
        for(int j=2; j<=temp; j++)
        {
            if(i%j==0)
            {
                flag = 1;
                break;
            }
        }
        if(flag == 0)
        {
            System.Console.Write($"{i} ");
        }
        i++;

        }
        
    }
}