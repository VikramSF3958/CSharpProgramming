using System;

namespace InsertionSort;

class Program 
{
    public static void Main(string[] args)
    {
        int[] InsertionSort = new int[] {18,19,1,5,7,3,20};

        for(int i=1; i<InsertionSort.Length; i++)
        {
            int key = InsertionSort[i];

            for(int j = i - 1; j >= 0; j-- )
            {
                if(InsertionSort[j] > key)
                {
                    int temp = 0;
                    temp = InsertionSort[j];
                    InsertionSort[j] = InsertionSort[j+1];
                    InsertionSort[j + 1] = temp;
                }
            }
        }

        for(int i=0; i<InsertionSort.Length; i++)
        {
            System.Console.Write($"{InsertionSort[i]} ");
        }
    }
}