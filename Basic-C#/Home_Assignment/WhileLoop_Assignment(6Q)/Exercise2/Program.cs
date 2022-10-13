using System; 

namespace Exercise2;

class Program 
{
    public static void Main(string[] args)
    {
        int sum = 0, initial = 1;

        System.Console.Write("Enter the count: ");
        int count = Convert.ToInt32(Console.ReadLine());

        while(initial <= count)
        {   

            System.Console.WriteLine($"{initial} ");
            sum += initial*initial;
            initial++;

        }

        System.Console.WriteLine($"Sum of Square: {sum}");
    }
}