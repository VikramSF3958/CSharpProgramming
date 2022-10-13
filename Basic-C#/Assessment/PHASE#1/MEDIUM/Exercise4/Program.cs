using System;

namespace Exercise4;

class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("< ----- ARMSTRONG NUMBER ----->");

        System.Console.Write("Lower Limit: ");
        int lowerLimit = Convert.ToInt32(Console.ReadLine());
        System.Console.Write("Enter upper limit: ");
        int upperLimit = Convert.ToInt32(Console.ReadLine());

        for(int i=lowerLimit; i<upperLimit; i++)
        {
        
            string stringNumber = i.ToString();

            int length = stringNumber.Length;
            int number = Convert.ToInt32(stringNumber);


            int temp = number, remainder = 0, newNumber = 0;

            while(temp > 0)
            {
                remainder = temp % 10;
                temp = temp /10;
                newNumber +=  Convert.ToInt32(Math.Pow((double)remainder, (double)length)) ;
            }

            if(number == newNumber)
            {
                System.Console.Write($"{newNumber} ");
            }

        }


    }
}