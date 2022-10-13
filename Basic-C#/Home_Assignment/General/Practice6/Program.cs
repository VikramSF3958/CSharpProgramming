using System;

namespace Practice6;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Price: ");
        int price = Convert.ToInt32(Console.ReadLine());

        double total = price + price * 0.18;

        Console.WriteLine($"Total Amount: {total}");
        
    }
}