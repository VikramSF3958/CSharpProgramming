using System;

namespace Exercise8;

class Program 
{
    public static void Main(string[] args)
    {   
        GetDetails();
        void GetDetails()
        {
            System.Console.WriteLine("Enter the marks: ");
            int[] number = new int[3] ;

            for(int i=0; i<3; i++)
            {   
                int element;
                System.Console.Write($"Mark-{i}: ");
                element = Convert.ToInt32(Console.ReadLine());
                number[i] = element;
            }

            double result = Percentage(number);
            System.Console.WriteLine($"The Percentage is: {result}%");
        }

         double Percentage(int[] array)
            {      
                int sum = 0;
                for(int i=0; i<3; i++)
                {
                    sum +=array[i];
                }


                return ((double)sum/300) * 100;
            }
    }
}