using System;

namespace Exercise3;

class Program 
{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter value1: ");
        int value1 = Convert.ToInt32(Console.ReadLine());

        System.Console.Write("Enter value2: ");
        int value2 = Convert.ToInt32(Console.ReadLine());
        Swap(value1, value2);


        void Swap(int value1, int value2)
        {
            System.Console.WriteLine($"Before Swapping the Numbers are:- \n Value1:{value1} and Value2:{value2}");

            value1 = value1 + value2;
            value2 = value1 - value2;
            value1 = value1 - value2;

            System.Console.WriteLine($"After Swapping the Numbers are:- \n Value1:{value1} and Value2:{value2}"); 

        }

        

    }
}