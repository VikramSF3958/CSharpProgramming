using System;

namespace DoWhileAssignment; 

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
                    System.Console.WriteLine($"{num} is EVEN number");
                }else
                {
                    System.Console.WriteLine($"{num} is ODD number");
                }

                System.Console.Write("Do you want to continue, Again ?: ");
                checker = Console.ReadLine().ToLower();

                if(checker!="yes" && checker!="no")
                {
                while(checker!="yes" && checker!="no")
                {
                    System.Console.Write("Invalid Input. Please provide valid input: ");
                    checker = Console.ReadLine().ToLower();

                    if(checker=="yes" && checker=="no")
                    {
                        break;
                    }
                }

                }

                
                




            }while(checker == "yes");
        }
    }
