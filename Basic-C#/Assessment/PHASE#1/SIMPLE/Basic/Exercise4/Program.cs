using System;

namespace Exercise4;

class Program 
{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter money in rupess: ");
        double rupees = Convert.ToDouble(Console.ReadLine());

        System.Console.WriteLine($"USD: ${rupees * 1.22}");
        System.Console.WriteLine($"EUR: {rupees * 1.27}");
        System.Console.WriteLine($"CNY: {rupees * 8.79}");
    }
}