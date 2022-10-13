using System;

namespace ArrayAssignment;

class Program 
{
    public static void Main(string[] args)
    {   
        int i, size;

        System.Console.Write("Enter the size of the Array: ");
        size = Convert.ToInt32(Console.ReadLine());


        string[] names = new string[size];

        System.Console.WriteLine("<__________INPUT_____________>");
        for(i = 0; i<size; i++)
        {
            names[i] = Console.ReadLine();
        }

        System.Console.WriteLine();
        System.Console.WriteLine("<__________NAME LIST_____________>");
        System.Console.WriteLine("The Names: ");
        for(i=0; i<size; i++)
        {
            System.Console.Write($"{names[i]},");
        }

        System.Console.WriteLine();
        System.Console.WriteLine("<___________________SEARCHING__________________>");
        System.Console.Write("Enter a name to Search: ");
        string searchName = Console.ReadLine();
        int flag = 0;
        System.Console.WriteLine("<--- USING FOR LOOP --->");
        for(i=0; i<size; i++)
        {
            if(names[i] == searchName)
            {
                flag = 1;
                System.Console.WriteLine($"The Name is present in the Array at the index {i+1}");
            }
        }
        if(flag == 0)
        {
           System.Console.WriteLine("The Name is not present in the Array");
        }

        System.Console.WriteLine();
        System.Console.WriteLine("<--- FOREACH LOOP --->");
        flag = 0;
        i=0;
        foreach (string strName in names)
        {  

            if(strName == searchName)
            {
                flag = 1;
                System.Console.WriteLine($"The Name is present in the Array at the index {i+1}");
            }
            i++;
        }

        if(flag == 0)
        {
           System.Console.WriteLine("The Name is not present in the Array");
        }
    }
}