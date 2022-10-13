using System;

namespace Exercise6;

class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter elements for 3 * 3 matrix-1: ");
        int[ , ] matrix1 = new int[ 3,3 ];
        int element = 0;

        for(int i=0;i<3;i++)
        {
            for(int j=0; j<3; j++)
            {
                System.Console.Write($"element - [{i}][{j}]: ");
                element = Convert.ToInt32(Console.ReadLine());

                matrix1[i , j] = element;
            }
        }

        System.Console.WriteLine();
        System.Console.WriteLine("Enter elements for 3 * 3 matrix-2: ");
        int[ , ] matrix2 = new int[ 3,3 ];
        int element2 = 0;

        for(int i=0;i<3;i++)
        {
            for(int j=0; j<3; j++)
            {
                System.Console.Write($"element - [{i}][{j}]: ");
                element2 = Convert.ToInt32(Console.ReadLine());

                matrix2[i , j] = element2;
            }
        }

        int[ , ] matrix3 = new int[ 3,3 ];

        for(int i=0;i<3;i++)
        {
            for(int j=0; j<3; j++)
            {
             matrix3[i,j] = matrix1[i,j] + matrix2[i,j];
            }
        }

         for(int i=0;i<3;i++)
        {   
            System.Console.WriteLine();
            for(int j=0; j<3; j++)
            {
            
                System.Console.Write($"{matrix3[i,j]} ");
            }
        }

    }
}