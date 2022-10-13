using System;
 namespace Exercise9;

 class Program 
 {
    public static void Main(string[] args)
    {   
        int sum = 0;
    
        System.Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int temp = number;
        int digit = 0;

        for(int i=0; i<3; i++)
        {
            digit = temp % 10;
            sum += digit * digit * digit;
            temp /= 10;
        }

        if(number == sum)
        {
            System.Console.WriteLine($"{number} is an Armstrong Number");
        }else
        {
            System.Console.WriteLine($"{number} is not an Armstrong Number");
        }



    }
 }