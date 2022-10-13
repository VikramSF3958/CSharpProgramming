using System;

namespace QuickSort;

class Program 
{
    public static void Main(string[] args)
    {
        int[] array = new int[] { 10, 8, 17, 5, 4, 15};

        Quick_Sort(array, 0, array.Length - 1);

        for(int i=0; i<array.Length; i++)
        {
            System.Console.Write($"{array[i]} ");
        }

    }

    static void swap(int[] array, int i, int j)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }

    static int Partitioning(int[] array1, int firstIndex, int lastIndex)
    {
        int pivot = array1[lastIndex];

        int i = firstIndex -1;
        int j = 0, temp;
        for(j = firstIndex; j<=lastIndex; j++)
        {
            if(array1[j] < pivot)
            {
                i++;
                swap(array1, i, j);
            }
        }
       
       swap(array1, i+1, lastIndex);
        return i+1;
    }
    static void Quick_Sort(int[] array, int firstIndex, int lastIndex)
    {
        if(firstIndex < lastIndex)
        {
            int sortedPosition = Partitioning(array, firstIndex, lastIndex);

            Quick_Sort(array, firstIndex, sortedPosition-1);
            Quick_Sort(array, sortedPosition+1, lastIndex);
        }
    }
}