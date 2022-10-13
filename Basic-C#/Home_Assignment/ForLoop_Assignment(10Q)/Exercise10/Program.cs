using System;
 namespace Exercise8;

 class Program 
 {
    public static void Main(string[] args)
    {
        System.Console.Write("Enter the Number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int temp = number/2, flag=0;
        for(int i=2; i<=temp; i++)
        {
            if(number%i==0)
            {
                System.Console.WriteLine($"{number} is not Prime ");
                flag = 1;
                break;
            }
        }
        if(flag == 0)
        {
            System.Console.WriteLine($"{number} is Prime");
        }
    }
 }