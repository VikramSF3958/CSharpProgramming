using System;
using System.Collections.Generic;


namespace Banking;
    static public class Operations
    {
        static List<AccountDetails> accounts = new List<AccountDetails>();

        static AccountDetails currentAccount = null;

        public static void Menu()
        {
            System.Console.WriteLine("Welcome, Do you want to proceed further: (yes/no)");
            string choice = Console.ReadLine();
            

            while(choice == "yes")
            {
                System.Console.WriteLine("Select Options: \n1.Registration \n2.Login \n3.Exit");
                System.Console.Write("Enter your Option: ");
                int option = Convert.ToInt32(Console.ReadLine());

                switch(option)
                {   
                    case 1:
                    {   
                        Console.Clear();
                        System.Console.WriteLine(" Registration ");
                        Registration();
                        System.Console.WriteLine();
                        break;
                    }

                    case 2:
                    {   
                        Console.Clear();
                        Login();
                        System.Console.WriteLine();
                        break;
                    }

                    case 3:
                    {   
                        System.Console.WriteLine("Exiting...");
                        choice = "no";
                        break;
                    }
                    default:
                    {
                        System.Console.WriteLine("Invalid Option");
                        break;
                    }
                }
            }
        }
    
        public static void Registration()
        {
            System.Console.WriteLine("<------- YOUR INFORMATION ----------->");
            System.Console.WriteLine("Enter Your details for creating your Bank account");

            System.Console.Write("Enter your full name: ");
            string name = Console.ReadLine();

            System.Console.Write("Enter your Father's Name: ");
            string fatherName = Console.ReadLine();

            System.Console.Write("Gender (Male/Female/Transgender) : ");
            Gender gender = Enum.Parse<Gender>(Console.ReadLine(), true);

            System.Console.Write("Your DOB in (dd/MM/yyyy): ");
            DateTime dob = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

            System.Console.Write("Enter the type of account: (Default/FD/RD/SD):  ");
            TypesAccount accountType = Enum.Parse<TypesAccount>(Console.ReadLine(), true);

            AccountDetails accDetails = new AccountDetails(name:name, fatherName:fatherName, gender:gender, dob:dob, accountType:accountType);

            accounts.Add(accDetails);

            System.Console.WriteLine();
            System.Console.WriteLine("Your has been Created, Successfully !!!");

            System.Console.WriteLine();
            System.Console.WriteLine($"Your Account Number is {accDetails.AccountNumber}");
        }

        public static void Login()
        {
            System.Console.WriteLine("  LOGIN   ");
            System.Console.WriteLine();

            System.Console.WriteLine("Account Number: ");
            string accountNumber = Console.ReadLine();
            
            foreach(AccountDetails obj in accounts)
            {
                if(obj.AccountNumber == accountNumber)
                {
                    System.Console.WriteLine("  Login SuccessFull   ");
                    System.Console.WriteLine();

                    currentAccount = obj;
                    SubMenu();
                }
                else
                {
                    System.Console.WriteLine("Wrong Registration Number");
                }
            }

        }

        public static void SubMenu()
        {
            System.Console.WriteLine();
            System.Console.WriteLine("Want to explore further options");
            string wish = "yes";

            while(wish == "yes")
            {
                System.Console.Write("\n1.Show Details \n2.Deposit\n3.WithDraw\n4.Show Balance\n5.EXIT ");
                int option = Convert.ToInt32(Console.ReadLine());

                switch(option)
                {
                    case 1:
                    {   
                        System.Console.WriteLine("  YOUR DETAILS    ");
                        currentAccount.showDetail();
                        break;
                    }

                    case 2:
                    {   
                        System.Console.WriteLine(" DEPOSIT  ");
                        currentAccount.DepositAmount();
                        break;
                    }

                    case 3:
                    {   
                        System.Console.WriteLine(" WITHDRAW ");
                        currentAccount.WithDrawAmount();
                        break;
                    }

                    case 4:
                    {   
                        System.Console.WriteLine(" BALANCE SHEET ");
                        currentAccount.BalanceSheet();
                        break;
                    }

                    case 5:
                    {
                        System.Console.WriteLine("Exiting SubMenu...");
                        wish = "no";
                        break;
                    }
                }
            }
        }
    
    }
