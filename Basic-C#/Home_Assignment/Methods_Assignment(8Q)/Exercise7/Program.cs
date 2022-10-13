using System;

namespace Exercise7;

class Program 
{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter the string: ");
        string content = Console.ReadLine();

 

        int result = Pallindrome(content);

        if(result == 1)
        {
            System.Console.WriteLine($"The string '{content} is palindrome");
        }else
        {
            System.Console.WriteLine($"The string '{content} is not palindrome");
        }

        int CheckPallindrome(string content, int first, int last)
        {
            if(first == last)
            {
                return 1;
            }

            if((content[first]) != (content[last]))
            {
                return 0;
            }

            if(first < last + 1)
            {
                return CheckPallindrome(content, first+1, last-1);
            }
            return 1;
        }

        int Pallindrome(string content)
        {   
            int length = content.Length; 

            if(length == 0)
            {
                return 1;
            }return CheckPallindrome(content, 0, length-1);
        }
    }
}