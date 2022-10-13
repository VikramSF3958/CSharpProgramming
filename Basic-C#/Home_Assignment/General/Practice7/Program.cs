using System;

namespace Practice7;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Input 'a': ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Input 'b': ");
        int b = Convert.ToInt32(Console.ReadLine());

        //(a + b)^2 = a^2 + b^2 + 2ab
        int result = a * a + b * b + 2 * a * b;

        Console.WriteLine($"(a + b)^2 = {result}");
    }
}