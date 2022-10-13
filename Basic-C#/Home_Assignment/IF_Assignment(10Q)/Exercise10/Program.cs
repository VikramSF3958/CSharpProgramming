using System;

namespace Exercise10;

class Program 
{
    public static void Main(string[] args)
    {   
        System.Console.Write("Hi, Vikram \n");
        System.Console.Write("Enter Your Password: ");
        string password = Console.ReadLine();

        if(password == "HiTeam")
        {
            System.Console.Write("Right Password");
        }else
        {
            System.Console.WriteLine("Wrong Password");
        }
    }
}