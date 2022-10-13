using System;

namespace Exercise2;

class Program 
{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter the String-1: ");
        string content = Console.ReadLine();

        int len = content.Length;

        System.Console.Write("Enter the String-2: ");
        string content1 = Console.ReadLine();

        int len1 = content1.Length;

        if(len!=len1)
        {
            System.Console.WriteLine("Both are not identical");
        }
        else
        {
            compare(content, content1);
        }

        void compare(string content, string content1)
            {   
                int flag = 0;
                for(int i=0;i<content.Length; i++)
                {
                    if(content[i] == content1[i])
                    {
                        flag = 1;
                    }
                    else
                    {
                        flag=0;
                        break;
                    }
                }

                if(flag==1)
                {
                    System.Console.WriteLine("Both are Identical");
                }
                else
                {
                    System.Console.WriteLine("Both are not Identical");
                }
            }




    }
}