using System;

namespace Exercise1;

class Program 
{
    public static void Main(string[] args)
    {
        string password = "s3cr3t!P@ssw0rd";

        System.Console.Write("Enter your password: ");
        string userPassword = Console.ReadLine();
        
        if(userPassword == password)
        {
            System.Console.WriteLine("WELCOME !, user");
        }
        else
        {
            System.Console.WriteLine("Wrong Password");
        }
    }
}