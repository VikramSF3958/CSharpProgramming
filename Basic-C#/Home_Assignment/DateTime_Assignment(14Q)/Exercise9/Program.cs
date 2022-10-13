using System;

namespace Exercise9;

class Program 
{
    public static void Main(string[] args)
    {
       DateTime obj, obj2 = new DateTime();
        System.Console.Write("Enter the date in format (dd/MM/yyyy): ");
        obj = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy",null);

        System.Console.Write("Enter the date in format (dd/MM/yyyy): ");
        obj2 = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy",null);

        int initialYear = obj.Year, finalYear = obj2.Year;
        int initialYearTemp = initialYear;
        int count = 0;

        while(initialYear <= finalYear)
        {   
            if(DateTime.IsLeapYear(initialYear))
            {
                System.Console.WriteLine($"{initialYear}");
                count++;
            }
            initialYear++;
        }

        System.Console.WriteLine($"{count} from {initialYearTemp} to {finalYear}");
    }
}