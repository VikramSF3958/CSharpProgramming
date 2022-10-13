using System;

namespace Exercise3;

class Program 
{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter a number:");
        int number = Convert.ToInt32(Console.ReadLine());

        int temp = number;
        int temp1 = number;

        int count = 0;
        for(int i = number; number > 0; number=number/10)
        {
            count++;
        }

        //int[] digits = new int[count];

        double digits = (double)count;
       int reverse = 0 , newNumber=0;

       while(temp >0)
       {
            reverse = temp % 10;
            temp = temp / 10;
            newNumber += reverse * Convert.ToInt32(Math.Pow(10, digits-1));
            digits--;
       }

       if(temp1 == newNumber)
       {
        System.Console.WriteLine($"{temp1} is pallindrome");
       }
       else
       {
        System.Console.WriteLine($"{temp1} is not a pallindrome");
       }

    }
}