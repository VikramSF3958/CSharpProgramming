using System;

namespace Practice5;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Physics: ");
        int phy = Convert.ToInt32(Console.ReadLine());

        Console.Write("Chemistry: ");
        int che = Convert.ToInt32(Console.ReadLine());

        Console.Write("Maths: ");
        int maths = Convert.ToInt32(Console.ReadLine());

        int sum = phy + che + maths;
        double percentage = (sum/300f) * 100;

        Console.WriteLine($"Physics - {phy}");
        Console.WriteLine($"Chemistry - {che}");
        Console.WriteLine($"Maths - {maths}");

        Console.WriteLine($"Sum = {sum}");
        Console.WriteLine($"Percentage = {percentage}%");
    }
}