using System;

namespace Exercise7;

class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("<--- Electricity Details --->\n");
        System.Console.WriteLine();

        System.Console.Write("Enter your CustomerID number: ");
        int customerId = Convert.ToInt32(Console.ReadLine());

        System.Console.Write("Enter your CustomerName: ");
        string customerName = Console.ReadLine();

        System.Console.Write("Enter the UNITS consumed: ");
        int units = Convert.ToInt32(Console.ReadLine());

        double netAmount = 0, surcharge = 0;

        if(units >= 199)
        {
            netAmount = units * 1.20;

            if(netAmount <= 100)
            {
                netAmount = 100;
            }
        }
        
        if(units >=200 && units < 400)
        {
            netAmount = units * 1.50;
            if(netAmount > 400)
            {
                surcharge = netAmount * 0.15;
                netAmount = netAmount + surcharge;
            }
        }

        if(units >= 400 && units < 600)
        {
            netAmount = units * 1.80;
            if(netAmount > 400)
            {
                surcharge = netAmount * 0.15;
                netAmount = netAmount + surcharge;
            }
        }

        if(units >= 600)
        {
            netAmount = units * 2.00;
            if(netAmount > 400)
            {
                surcharge = netAmount * 0.15;
                netAmount = netAmount + surcharge;
            }
        }

        System.Console.WriteLine();
        System.Console.WriteLine(" <-------- ELECTRICITY BILL ----------> ");
        System.Console.WriteLine();

        System.Console.Write($"CustomerIDNO: {customerId}");
        System.Console.WriteLine();
        System.Console.Write($"Customer Name: {customerName}");
        System.Console.WriteLine();
        System.Console.Write($"UNITS Consumed: {units}");
        System.Console.WriteLine();
        System.Console.Write($"Surcharge Amount: ${surcharge}");
        System.Console.WriteLine();
        System.Console.Write($"netAmount Paid by the Customer: ${netAmount}");

    }
}