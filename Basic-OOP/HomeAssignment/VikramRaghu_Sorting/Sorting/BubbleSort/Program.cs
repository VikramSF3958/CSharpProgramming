using System;

namespace BubbleSort;

class Program 
{
    public static void Main(string[] args)
    {
        int[]  bubbleSort = new int[] {18,19,1,5,7,3,20};

        DateTime first = DateTime.Now;
        //To run for Length times
        for(int i=0; i<bubbleSort.Length-1; i++)
        {   
            //Till the last sorted element
            for(int j=0; j<bubbleSort.Length-i-1; j++)
            {   
                //Comparing adjacent elements
                if(bubbleSort[j] > bubbleSort[j+1])
                {
                    int temp = 0;
                    temp = bubbleSort[j];
                    bubbleSort[j] = bubbleSort[j+1];
                    bubbleSort[j+1] = temp;
                }
            }
        }

        //Calculating time taken to complete the operation
        DateTime second = DateTime.Now;
        TimeSpan total = (second - first);

        System.Console.WriteLine(total.TotalSeconds);
        System.Console.WriteLine();

        //Printing the sorted array.
        for(int i=0; i<bubbleSort.Length; i++)
        {
            System.Console.Write($"{bubbleSort[i]}, ");
        }
    }
}