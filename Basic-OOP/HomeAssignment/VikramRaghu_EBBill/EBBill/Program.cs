using System;

namespace EBBill;

class Program 
{
    public static void Main(string[] args)
    {
        List<BillDetails> Bill = new List<BillDetails>();

        System.Console.Write("Do you want add to see your bill: ");
        String wish = "yes";

        while(wish == "yes")
        {
            System.Console.WriteLine();
            System.Console.Write("Enter your UserName: ");
            String userName = Console.ReadLine();

            System.Console.Write("Enter your PhoneNumber: ");
            long phoneNumber = Convert.ToInt64(Console.ReadLine());
            
            System.Console.Write("Enter your MailID: ");
            String mailId = Console.ReadLine();
            
            System.Console.Write("Enter Units consumed: ");
            int unitsConsumed = Convert.ToInt32(Console.ReadLine());

            BillDetails obj = new BillDetails(userName, phoneNumber, mailId, unitsConsumed);

            Bill.Add(obj);

            System.Console.WriteLine();
            System.Console.WriteLine("  Record Added Successfully   ");

            System.Console.Write("Do you want add more records ");
            wish = Console.ReadLine();
            
        }

        foreach(BillDetails obj in Bill)
        {
            System.Console.WriteLine();
            System.Console.WriteLine("<----- BILL GENERATED ------->");

            System.Console.WriteLine($"Meter ID: {obj.MeterID}");
            System.Console.WriteLine($"User Name: {obj.UserName}");
            System.Console.WriteLine($"Phone Number: {obj.PhoneNumeber}");
            System.Console.WriteLine($"Mail ID: {obj.MailId}");
            System.Console.WriteLine($"Units Consumed: {obj.UnitsUsed}");
            
            obj.CalculateAmount();
        }
    }
}