using System;

namespace Exercise5;

class Program 
{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter the string: ");
        string content = Console.ReadLine();

        char[] ch = content.ToCharArray();
        char[] revch = new Char[ch.Length];

        int index = 0;
        for(int i=ch.Length-1; i>=0; i--)
        {
            revch[index] = ch[i];
            index++;
        }

        int flag = 0;
        for(int i=1;i<ch.Length; i++)
        {
            if(ch[i]!=revch[i])
            {
                flag = 1;
                break;
            }
        }

        if(flag==0)
        {
            System.Console.WriteLine("Its Pallindrome");
        }
        else
        {
            System.Console.WriteLine("Not a Pallindrome");
        }

        
    }
}