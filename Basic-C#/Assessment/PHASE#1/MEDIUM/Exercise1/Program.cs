using System;

namespace Exercise1;

class Program
{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter Basic Salary: ");
        double basicSalary = Convert.ToDouble(Console.ReadLine());

        if(basicSalary <= 10000)
        {
            double HRA = basicSalary * 0.20;
            double DA = basicSalary * 0.80;
            double annualGrossSalary = (basicSalary + HRA + DA) * 12;

            double taxDeduce = annualGrossSalary * 0.06;
            double insurance = annualGrossSalary * 0.01;

            double takeHomeSalary = annualGrossSalary - taxDeduce - insurance;

            System.Console.WriteLine($"Annual Gross income: {annualGrossSalary}");
            System.Console.WriteLine($"Take Home Salary: {takeHomeSalary}");

        }
        else
        {
            if(basicSalary > 10000 && basicSalary <=20000)
            {
            
            double HRA = basicSalary * 0.25;
            double DA = basicSalary * 0.90;
            double annualGrossSalary = (basicSalary + HRA + DA) * 12;

            double taxDeduce = annualGrossSalary * 0.06;
            double insurance = annualGrossSalary * 0.01;

            double takeHomeSalary = annualGrossSalary - taxDeduce - insurance;

            System.Console.WriteLine($"Annual Gross income: {annualGrossSalary}");
            System.Console.WriteLine($"Take Home Salary: {takeHomeSalary}");

            }
            else
            {
                if(basicSalary > 20000 )
                {
                    double HRA = basicSalary * 0.30;
                    double DA = basicSalary * 0.95;
                    double annualGrossSalary = (basicSalary + HRA + DA) * 12;

                    double taxDeduce = annualGrossSalary * 0.06;
                    double insurance = annualGrossSalary * 0.01;

                    double takeHomeSalary = annualGrossSalary - taxDeduce - insurance;

                    System.Console.WriteLine($"Annual Gross income: {annualGrossSalary}");
                    System.Console.WriteLine($"Take Home Salary: {takeHomeSalary}");

                }
            }
        }
    }
}