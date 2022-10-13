using System;

namespace Exercise1;

class Program 
{
    public static void Main(string[] args)
    {   
        int columns02, rows2;

        columns02 = 2;
        rows2 = 3;
        int[,] matrix2 = new int[rows2,columns02];
        int element2;

        System.Console.WriteLine("Enter Matrix-2 of (3 X 2): ");
        for(int i=0; i<rows2; i++)
        {   
            for(int j=0; j<columns02; j++)
            {
                element2 = Convert.ToInt32(Console.ReadLine());
                matrix2[i,j] = element2;
            }
        }
        System.Console.WriteLine();
        System.Console.WriteLine("MATRIX-2");
        for(int i=0; i<rows2; i++)
        {   
            System.Console.WriteLine();
            for(int j=0; j<columns02; j++)
            {
                System.Console.Write($"{matrix2[i,j]}  ");
            }
        }


        int column1, row1;
        column1 = 3;
        row1 = 2;

        int[,] matrix1 = new int[row1,column1];
        int element1;

        System.Console.WriteLine();
        System.Console.WriteLine("Enter Matrix-1 of (3 X 2): ");
        for(int i=0; i<row1; i++)
        {   
            for(int j=0; j<column1; j++)
            {
                element1 = Convert.ToInt32(Console.ReadLine());
                matrix1[i,j] = element1;
            }
        }

        System.Console.WriteLine();
        System.Console.WriteLine("MATRIX-1");
        for(int i=0; i<row1; i++)
        {   
            System.Console.WriteLine();
            for(int j=0; j<column1; j++)
            {
                System.Console.Write($"{matrix1[i,j]}  ");
            }
        }



        int[,] matrix3 = new int[2,2];


        for(int i=0; i<row1; i++)
        {   
            for(int j=0; j<columns02; j++)
            {   matrix3[i,j] = 0;
               for(int k=0; k<column1; k++)
               {
                matrix3[i,j] += matrix1[i,k] * matrix2[k,j];
               }
            }
           
        }

        for(int i=0; i<2; i++)
        {   
            System.Console.WriteLine();
            for(int j=0; j<2; j++)
            {
                System.Console.Write($"{matrix3[i,j]} ");
            }
        }

    }
}