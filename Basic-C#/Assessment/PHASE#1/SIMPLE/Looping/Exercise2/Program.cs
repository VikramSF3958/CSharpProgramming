using System;

namespace Exercise2;

class Program 
{
    public static void Main(string[] args)
    {   
        int square = 0;
        for(int i=1; i<100; i++)
        {
            if(i%2==1)
            {
                square += i*i;
            }
        }

        System.Console.WriteLine($"Sum of Squares of odd values in range 1-99: {square}");
    }
}