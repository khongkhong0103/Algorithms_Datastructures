using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Sorting
{
    internal class Bubble
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bubble Sort");
            Array();
        }

  
        static void Array()
        {
            int[] array = { 7, 2, 12, 8, 3 };
            Console.WriteLine("Mang truoc khi sap xep ");
            foreach (int i in array)
            {
                Console.Write($" {i}");
            }
            BubbleSort(array);
            Console.WriteLine("\nMang sau khi sap xep ");
            foreach (int i in array)
            {
                Console.Write($" {i}");
            }
        }
        static int[] BubbleSort(int[] array)
        {
            int lenght = array.Length;
            for (int i = lenght - 1; i >= 1; i--)
            {
                for (int k = 0; k < i; k++)
                {
                    if (array[k] > array[k + 1])
                    {
                        // swap 
                        array[k] ^= array[k + 1];
                        array[k + 1] ^= array[k];
                        array[k] ^= array[k + 1];
                    }
                }
            }
            return array;
        }
    }
}
