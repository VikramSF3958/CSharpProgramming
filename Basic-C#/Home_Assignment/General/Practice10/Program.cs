using System;

namespace Practice10;

class Program
{
    public static void Main(string[] args)
    {
        int value1 = 15;
        int value2 = 20;

        if(value1 > value2)
        {
            System.Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
        

        if(value1 < value2)
        {
            Console.WriteLine("True");
        }
        else
        {
            System.Console.WriteLine("False");
        }
        

        if(value1 >= value2)
        {
            Console.WriteLine("True");
        }
        else
        {
            System.Console.WriteLine("False");
        }
        

        if(value1 == value2)
        {
            Console.WriteLine("False");
        }
        else
        {
            System.Console.WriteLine("True");
        }
       

        if(value1!=value2)
        {
            Console.WriteLine("False");
        }
        else
        {
            System.Console.WriteLine("True");
        }

        if(value1 <= value2)
        {
            Console.WriteLine("True");
        }
        else
        {
            System.Console.WriteLine("False");
        }
        

        if(value1 >= 10 && value2 >= 10)
        {
            System.Console.WriteLine("True");
        }
        else
        {
            System.Console.WriteLine("False");
        }        

        if(value1 >= 10 || value2 >= 30)
        {
            System.Console.WriteLine("True");
        }
        else
        {
            System.Console.WriteLine("False");
        }
        

        if(!(value1>20))
        {
            System.Console.WriteLine("True");
        }
        else
        {
            System.Console.WriteLine("False");
        }
        

        String value = (value1==15 ? "True" : "false");
        System.Console.WriteLine(value);

        value1++;
        Console.WriteLine($"Value++: {value1}");

        value1--;
        System.Console.WriteLine($"Value--: {value1}");


    }
}