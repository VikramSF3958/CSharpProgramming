using System;

namespace Exercise8;

class Program 
{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter your sugar level: ");
        int sugarLevel = Convert.ToInt32(Console.ReadLine());

        if(sugarLevel < 90)
        {
            System.Console.Write("Low Sugar");
        }else
        {
            if(sugarLevel >= 90 && sugarLevel < 130)
            {
                System.Console.Write("Normal");
            }else
            {
                if(sugarLevel >=130 && sugarLevel  < 140)
                {
                    System.Console.Write("Medium");
                }else
                {
                    if(sugarLevel >= 140 && sugarLevel < 170)
                    {
                        System.Console.Write("Try to reduce it from now");
                    }else
                    {
                        if(sugarLevel >= 170)
                        {
                            System.Console.Write("You are a very high sugar patient");
                        }
                    }
                }
            }
        }
    }
}