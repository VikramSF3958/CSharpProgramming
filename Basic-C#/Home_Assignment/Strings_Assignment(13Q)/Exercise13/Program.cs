using System;

namespace Exercise13;

class Program 
{
    public static void Main(string[] args)
    {
        int sum = 0;
        System.Console.Write("Enter the String: ");
        string content = Console.ReadLine();
        
        foreach(char text in content)
        {
            if( (int)text >= 48 && (int)text <= 57 )
            {
                sum += text -'0';
            }
        }

        System.Console.WriteLine($"The sum: {sum}");

    }
}