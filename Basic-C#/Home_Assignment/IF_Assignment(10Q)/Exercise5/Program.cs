using System;

namespace Excersie5;

class Program
{
    public static void Main(string[] args)
    {   
        System.Console.WriteLine("<--- Enter Marks --->");
        System.Console.Write("Physics: ");
        int phy = Convert.ToInt32(Console.ReadLine());

        System.Console.Write("Chemistry: ");
        int che = Convert.ToInt32(Console.ReadLine());

        System.Console.Write("Mathematics: ");
        int maths = Convert.ToInt32(Console.ReadLine());

        int sum = phy + che + maths;

        double percentage = ((double)sum/300) * 100;

        if(percentage >= 75)
        {
            System.Console.WriteLine("The canditate is eligible for admission");
        }
        else
        {
            System.Console.WriteLine("The canditate is NOT eligible for admission");
        }
    }
}