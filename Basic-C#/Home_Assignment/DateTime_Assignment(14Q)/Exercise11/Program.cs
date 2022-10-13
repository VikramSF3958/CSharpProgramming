using System;

namespace Exercise11;
    class Program
    {
        public static void Main(string[] args)
        {
            DateTime obj = new DateTime();
            obj = DateTime.Now;

            System.Console.WriteLine($"The date of today: {obj.Date}");

            int count = 0;
            System.Console.WriteLine("The twelve months are: ");

            while(count<12)
            {
                System.Console.WriteLine($"{obj.AddMonths(count).ToString("MMMM")} ");
                count++;
            }
        }
    }
