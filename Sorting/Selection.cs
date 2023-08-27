using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    internal class Selection
    {

        /* Sắp xếp lựa chọn là một thuật toán sắp xếp một mảng trong đó nó lặp từ đầu vòng lặp và kiểm tra các phần tử khác để tìm giá trị tối thiểu.
         * Sau khi kết thúc lần lặp đầu tiên, giá trị tối thiểu được hoán đổi với phần tử hiện tại. Việc lặp lại sau đó tiếp tục từ phần tử thứ 2, v.v.
         * link: https://youtube.com/playlist?list=PLprfEn_dJT0_z-A6FlUYjYJVLh4RrmoiZ&si=hPg9ZLn-JZ_t1lXw
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Selection Soret program in c# ");
            int array_size = 10;
            int[] array = new int[10] { 100, 50, 20, 40, 10, 60, 80, 70, 90, 30 };
            Console.WriteLine("The array before selection sort is: ");
            for (int i = 0; i < array_size; i++)
            {
                Console.Write(" {0}",array[i]);
            }
            int tmp, min_key;
            for(int j = 0; j < array_size -1; j++)
            {
                min_key = j;
                for (int k = j+1; k < array_size; k++)
                {
                    if (array[k] < array[min_key]) {
                        min_key = k;
                    }
                }
                tmp= array[min_key];
                array[min_key] = array[j];
                array[j] = tmp;
            }
            Console.WriteLine("\nThe array after Selection Sort is: ");
            for(int i = 0;i < array_size;i++)
            {
                Console.Write(" {0}",array[i]);
            }
            Console.ReadLine();
        }
    }
}
