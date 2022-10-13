using System;

namespace Exercise4;

class Program 
{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter your salary month: ");
        int month = Convert.ToInt32(Console.ReadLine());

        System.Console.Write("Enter Leave taken in that month: ");
        int leave = Convert.ToInt32(Console.ReadLine());

        switch(month)
        {
            case 1:
            {   
                System.Console.WriteLine($"January Salary: {monthlySalary(month, leave, 31)}");
                break;
            }

            case 2:
            {   
                System.Console.WriteLine($"Febrauray Salary: {monthlySalary(month, leave, 28)}");
                break;
            }

            case 3:
            {   
                System.Console.WriteLine($"March Salary: {monthlySalary(month, leave, 30)}");
                break;
            }

            case 4:
            {   
                System.Console.WriteLine($"April Salary: {monthlySalary(month, leave, 31)}");
                break;
            }
            
            case 5:
            {   
                System.Console.WriteLine($"May Salary: {monthlySalary(month, leave, 31)}");
                break;
            }

            case 6:
            {   
                System.Console.WriteLine($"June Salary: {monthlySalary(month, leave, 30)}");
                break;
            }

            case 7:
            {   
                System.Console.WriteLine($"July Salary: {monthlySalary(month, leave, 31)}");
                break;
            }

            case 8:
            {   
                System.Console.WriteLine($"August Salary: {monthlySalary(month, leave, 31)}");
                break;
            }

            case 9:
            {   
                System.Console.WriteLine($"September Salary: {monthlySalary(month, leave, 30)}");
                break;
            }

            case 10:
            {   
                System.Console.WriteLine($"October Salary: {monthlySalary(month, leave, 31)}");
                break;
            }

            case 11:
            {   
                System.Console.WriteLine($"November Salary: {monthlySalary(month, leave, 30)}");
                break;
            }
            
            case 12:
            {   
                System.Console.WriteLine($"December Salary: {monthlySalary(month, leave, 31)}");
                break;
            }

            default:
            {
                System.Console.WriteLine("Invalid Month!");
                break;
            }



        }

        double monthlySalary(int month, int leave, int days)
        {   
            
            double grossSalary = (double)500 * days;
            double lossOfPay = (double)500 * leave;

            return grossSalary - lossOfPay;

        }
    }
}