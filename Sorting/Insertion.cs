using System;

namespace Sorting
{
    internal class Insertion
    {
        /*
           Link: https://youtube.com/playlist?list=PLprfEn_dJT0_fRZtS1w0WD8kXaYqUD5ch&si=SE6sGH-x_ebTsEyr  
          Chia 1 array thanh 2 array  
         */
        private const int ArraySize = 5;

        static void Main(string[] args)
        {
            Console.WriteLine("Insertion sort is of order O(n^2)");
            int[] arr = new int[ArraySize] { 83, 12, 3, 34, 60 };
            Console.WriteLine("\nThe array is: ");
            for (int i = 0; i < ArraySize; i++)
            {
                Console.Write(" {0}", arr[i]);
            }
            InsertionSort(arr);
            Console.WriteLine("\nThe sorted array is: ");
            for (int i = 0; i < ArraySize; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
        }

        private static void InsertionSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; i++)
            {
                int item = arr[i];
                int j = i - 1;
                for (j; j >= 0 && arr[j] > item; j--)
                {
                    arr[j + 1] = arr[j];
                }
                arr[j + 1] = item;
                /*   while (j >= 0 && arr[j] > item)
                   {
                       arr[j + 1] = arr[j];
                       j--;
                   }
                   arr[j + 1] = item;*/
            }
        }
    }
}
