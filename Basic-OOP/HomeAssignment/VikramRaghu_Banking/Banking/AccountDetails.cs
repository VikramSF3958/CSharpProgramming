using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Banking;
  
    public enum Gender { Default, Male, Female, Transgender };
    public enum TypesAccount { Default, FD, SD, RD};
    public class AccountDetails
    {   
        private static int  s_accountNumber = 1000;
        public string Name { get; set; }

        public string AccountNumber { get;  }

        public string FatherName { get; set; }
        public Gender Gender { get; set; }

        public DateTime DOB { get; set; }

        public TypesAccount AccountType { get; set; }

        public double AccountBalance { get; set; }

        // public AccountDetails()
        // {

        // }

        public AccountDetails(string name, string fatherName, Gender gender, DateTime dob, TypesAccount accountType)
        {   
            s_accountNumber+=9;
            AccountNumber = "HDFC"+s_accountNumber;
            Name = name;
            FatherName = fatherName;
            Gender = gender;
            DOB = dob;
            AccountType = accountType;
        }

        public void showDetail()
        {
            System.Console.WriteLine("Your created ACCOUNT DETAILS");
            System.Console.WriteLine($"Account Number: {AccountNumber}");
            System.Console.WriteLine($"Name:          {Name}");
            System.Console.WriteLine($"Father's Name: {FatherName}");
            System.Console.WriteLine($"Gender:        {Gender}");
            System.Console.WriteLine($"DOB:           {DOB.ToString("dd/MM/yyyy")}");
            System.Console.WriteLine($"Account Type:  {AccountType}");
            System.Console.WriteLine($"Account Balance: ${AccountBalance}");
        }
        public void DepositAmount()
        {
            System.Console.Write("Enter amount to deposit: $");
            double amount = Convert.ToDouble(Console.ReadLine());

            AccountBalance += amount;

            System.Console.WriteLine("Amount Successfully added to your account");
        }

        public void WithDrawAmount()
        {
            System.Console.Write("Enter amount to withdraw: $");
            double amount = Convert.ToDouble(Console.ReadLine());

            AccountBalance -= amount;

            System.Console.WriteLine("Amount Deducted from your account");
        }

        public void BalanceSheet()
        {
            System.Console.Write("Balance :");
            System.Console.WriteLine(AccountBalance);
        }

        public void ShowBalance()
        {
            System.Console.WriteLine($"Balance: ${AccountBalance}");
        }

    }
