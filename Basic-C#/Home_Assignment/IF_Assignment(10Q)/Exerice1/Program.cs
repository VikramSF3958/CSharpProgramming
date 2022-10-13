using System;

namespace Exerice1;

class Program
{
    public static void Main(string[] args)
    {
        int testdata = 15;

        if(testdata % 2 == 0)
        {
            System.Console.WriteLine($"{testdata} is even integer");
        }
        else
        {
            System.Console.WriteLine($"{testdata} is odd integer");
        }
    }
}