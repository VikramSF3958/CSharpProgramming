using System;

namespace Exercise5;

class Program 
{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int flag1 = PrimeCheck(number);
        if(flag1 == 1)
        {
            System.Console.WriteLine($"The number {number} is not a Prime Number");
        }else
        {
            System.Console.WriteLine($"The number {number} is Prime number");
        }
       
        int PrimeCheck(int number)
        {
            int temp = number/2, flag=0;
            for(int i=2; i<=temp; i++)
            {
                if(number%i==0)
                {
                    flag = 1;
                    break;
                }
            }
            return flag;
        }
    }
}