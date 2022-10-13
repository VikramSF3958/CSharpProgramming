using System;

namespace Exercise6;

class Program
{
    public static void Main(string[] args)
    {   
        System.Console.WriteLine("<--- Weather --->");
        System.Console.Write("Enter the temperature in centigrade: ");
        int temperature = Convert.ToInt32(Console.ReadLine());

        if(temperature < 0 )
        {
            System.Console.WriteLine("Freezing Weather");
        }

        if(temperature >=0 && temperature < 10)
        {
            System.Console.WriteLine("Very Cold Weather");
        }

        if(temperature >= 10 && temperature < 20)
        {
            System.Console.WriteLine("Cold Weather");
        }

        if(temperature >= 20 && temperature < 30)
        {
            System.Console.WriteLine("Normal in Temperature");
        }

        if(temperature >=30 && temperature < 40)
        {
            System.Console.WriteLine("Its Hot !");
        }
         
         if(temperature >=40 )
         {
            System.Console.WriteLine("Its Very Hot");
         }
    }
}