using System;

namespace Exercise2;

class Program
{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter Age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        if(age >= 18)
        {
            System.Console.WriteLine("Congratulations!\n You're eligible for casting your vote");
        }
        else
        {
            System.Console.WriteLine("You're not eligible");
        }
    }
}