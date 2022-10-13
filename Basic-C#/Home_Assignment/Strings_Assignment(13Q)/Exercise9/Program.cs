using System;

namespace Exercise9;

class Program 
{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter the string:");
        string content = Console.ReadLine();

        System.Console.Write("Enter the sub-string: ");
        string substring = Console.ReadLine();

        int flag = 0;
        
        for(int i=0; i<=content.Length - substring.Length; i++)
        {
            for(int j=i; j<i+substring.Length; j++)
            {
                flag = 1;
                if(content[j]!=substring[j-i])
                {
                    flag=0;
                    break;
                }

            }
            if(flag==1)
            {
                break;
            }
        }

        if(flag==1)
        {
            System.Console.WriteLine("The substring exists");
        }
        else
        {
            System.Console.WriteLine("The substring doesn't exists");
        }
    }

}