using System;

namespace Exercise14;

class Program 
{
    public static void Main(string[] args)
    {   
        System.Console.Write("Enter year: ");
        int year = Convert.ToInt32(Console.ReadLine());

        System.Console.Write("Enter month (in number): ");
        int month = Convert.ToInt32(Console.ReadLine());

        System.Console.Write("Enter number of leaves: ");
        int leaves = Convert.ToInt32(Console.ReadLine());

        int dayInMonth = DateTime.DaysInMonth(year, month);

        int monthSalary = dayInMonth * 500;
        int lossOfPay = leaves * 500;

        int netAmountSalary = monthSalary - lossOfPay;

        System.Console.WriteLine($"NET SALARY: {netAmountSalary}");
    }
}