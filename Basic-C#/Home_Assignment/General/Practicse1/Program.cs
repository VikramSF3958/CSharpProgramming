using System;

namespace practice1;

class Program
{
    public static void Main(string[] args)
    {   
        string name = "Vikram R";
        string hello = "Hello";
        Console.WriteLine(hello + ": " + name);
        Console.WriteLine("{0}: {1}",hello, name);
        Console.WriteLine($"{hello}: {name}");
    }
}