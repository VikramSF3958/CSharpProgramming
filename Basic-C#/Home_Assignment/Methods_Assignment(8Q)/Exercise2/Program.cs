using System;

namespace Exercise2;

class Progam 
{
    public static void Main(string[] args)
    {   
        
        System.Console.Write("Enter a Context: ");
        string content = Console.ReadLine();

        System.Console.WriteLine($"The content is:  ' {ContentMethod(content)} ' ");


        string ContentMethod(string input)
        {
            return input;
        }
    }
}