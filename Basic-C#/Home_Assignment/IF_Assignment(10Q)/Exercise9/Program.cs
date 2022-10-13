using System;

namespace Excercise9;

class Program 
{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter the month (in full words 1st letter should be capital): ");
        string month = Console.ReadLine();

        if(month == "December" || month == "January" || month == "Febraury")
        {
            System.Console.Write("Winter Season");
        }else
        {
            if(month == "March" || month == "April" || month == "May")
            {
                System.Console.Write("Spring Season");
            }else
            {
                if(month == "June" || month == "July" || month == "August")
                {
                    System.Console.Write("Summer Season");
                }else
                {
                    if(month == "September" || month == "October" || month == "November")
                    {
                        System.Console.Write("Rainfall");
                    }
                }
            }
        }
    }
}