using System;

namespace Practice8;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the Length in meter: ");
        double meter = Convert.ToDouble(Console.ReadLine());

        double CM = meter * 100;
        double Mm = CM * 10;
        double Inch = 39.3 * meter;
        double Foot = 12 * meter;
        double Mile = 0.0006213715277778D * meter;

        Console.WriteLine($"{meter}m -> CM = {CM}");
        Console.WriteLine($"{meter}m - > Mm = {Mm}");
        Console.WriteLine($"{meter}m - > Inch = {Inch}");
        Console.WriteLine($"{meter}m - > Foot = {Foot}");
        Console.WriteLine($"{meter}m - > Mile = {Mile}");

    }
}