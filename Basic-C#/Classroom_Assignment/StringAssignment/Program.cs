using System;

namespace StringAssignment;

class Program 
{
    public static void Main(string[] args)
    {   
        System.Console.Write("Enter the string: ");
        //string context = Console.ReadLine();
        string context = "vkykedivk";
    

        System.Console.Write("Enter the substring: ");
        //string context1 = Console.ReadLine();
        string context1 = "k";

        bool value = context.Contains(context1);

        int count = 0;
        if(value)
        {
            string[] sub = context.Split(context1);
            count = sub.Length - 1;
           
        }else
        {
            System.Console.WriteLine("The SubString is not FOUND in the entered String");
        }

        System.Console.Write($"Total substring: {count}");


    }
}