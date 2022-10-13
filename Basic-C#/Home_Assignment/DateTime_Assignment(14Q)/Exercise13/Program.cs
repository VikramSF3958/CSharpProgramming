using System;

namespace Exercise13;

class Program 
{
    public static void Main(string[] args)
    {
        DateTime date;

        System.Console.Write("Enter date");
        System.Console.Write("Enter the date in format (yyyy/MM/dd): ");
        date = DateTime.ParseExact(Console.ReadLine(), "yyyy/MM/dd", null);

        System.Console.WriteLine($"The formatted date is: {date.ToString("dd/MM/yyyy")}");

        int count=0;
       while(true)
       {
        if(date.AddDays(count).DayOfWeek.ToString() == "Sunday" )
        {
            System.Console.WriteLine($"The last day of the week for above date is: {date.AddDays(count).Date}");
            break;
        }
        count++;
       }
    }
}