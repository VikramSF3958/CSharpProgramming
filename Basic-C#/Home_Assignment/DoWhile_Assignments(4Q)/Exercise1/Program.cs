using System;

namespace Exercise1; 

    class Program 
    {
        public static void Main(string[] args)
        {   
            int num;
            string checker = " ";
            do
            {   
                System.Console.Write("Enter a number: ");
                num = Convert.ToInt32(Console.ReadLine());

                if(num%2==0)
                {
                    System.Console.WriteLine($"Give {num} is EVEN number");
                }else
                {
                    System.Console.WriteLine($"Given {num} is ODD number");
                }

                System.Console.Write("Do you want to continue, Again ?: ");
                checker = Console.ReadLine().ToLower();

            }while(checker == "yes");
        }
    }
