using System;

namespace Exercise3;

class Program 
{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter a string-0: ");
        string nameOne = Console.ReadLine();

        System.Console.Write("Enter a string-1: ");
        string nameTwo = Console.ReadLine();

        char[] one = nameOne.ToCharArray();
        char[] two = nameTwo.ToCharArray();

        int[] oneAscii = new int[nameOne.Length];
        for(int i=0; i<one.Length; i++)
        {
            oneAscii[i] = (int)one[i];
        }

        int[] twoAscii = new int[nameOne.Length];
        for(int i=0; i<two.Length; i++)
        {
            twoAscii[i] = (int)one[i];
        }

        Array.Sort(oneAscii);
        Array.Sort(twoAscii);
        int flag = 0;

        for(int i=0;i<oneAscii.Length;i++)
        {   
            if(oneAscii.Length!=twoAscii.Length)
            {
                 System.Console.Write("Not an Ambigram");
                 flag = 1;
                 break;
            }
            if(oneAscii[i]!=twoAscii[i])
            {
                System.Console.WriteLine("Not an Ambigram");
                flag = 1;
                break;
            }
        }

        if(flag==0)
        {
            System.Console.WriteLine("TWO WORDS ARE AMBIGRAM");
        }

    }
}