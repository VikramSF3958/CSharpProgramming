using System;

namespace Exercise5;

class Program 
{
    public static void Main(string[] args)
    {
        double basicSalary = 10000;

        double DA = basicSalary * 0.10;
        double HRA = basicSalary * 0.10;

        double monthSalary = basicSalary + DA + HRA;

        double annualIncome = monthSalary * 12;

        double taxDeduced = annualIncome * 0.05;

        double netAnnualIncome = annualIncome - taxDeduced;

        System.Console.WriteLine();
        System.Console.WriteLine($"AnnualSalary: {netAnnualIncome}");
    }
}