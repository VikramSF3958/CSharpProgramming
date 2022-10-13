using System;

namespace Exercise5;

class Program 
{
    public static void Main(string[] args)
    {   
        DateTime date1 ,date2;

        System.Console.Write("Enter 1st date");
        System.Console.Write("Enter the date in format (yyyy/MM/dd): ");
        date1 = DateTime.ParseExact(Console.ReadLine(), "yyyy/MM/dd", null);

        System.Console.Write("Enter 2nd date");
        System.Console.Write("Enter the date in format (dd/MM/yyyy): ");
        date2 = DateTime.ParseExact(Console.ReadLine(), "yyyy/MM/dd", null);

        int year1 = date1.Year;
        int year2 = date2.Year;

        int count = date1.Year - date2.Year;

        if(count < 0)
        {
            count = date2.Year - date1.Year;
        }
        
        for(int i=0; i<8; i++)
        {   
            DateTime date3 = date1.AddYears(i);
            System.Console.WriteLine(" {0}: day {1} {2}  {3} ", date3.Date,date3.DayOfYear,date3.Year, DateTime.IsLeapYear(date3.Year)?"(Leap Year)":" ");

        }

    }
}