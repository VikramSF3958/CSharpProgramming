using System;

namespace SelectionSort;

class Program 
{
    public static void Main(string[] args)
    {
        int[] selectionSort = new int[]{18,19,1,5,7,3,20};
        int pos = 0;
        for(int i=0; i<selectionSort.Length;i++)
        {
            int minValue = selectionSort[i];
            for(int j=i+1; j<selectionSort.Length;j++)
            {
                if(minValue > selectionSort[j])
                {
                    minValue = selectionSort[j];
                    pos = j;
                }
            }
            if(minValue < selectionSort[i])
            {
                int temp = 0;
                temp = selectionSort[i];
                selectionSort[i] = selectionSort[pos];
                selectionSort[pos] = temp;
            }
        }

        for(int i=0; i<selectionSort.Length;i++)
        {
            System.Console.Write($"{selectionSort[i]} ");
        }
    }
}