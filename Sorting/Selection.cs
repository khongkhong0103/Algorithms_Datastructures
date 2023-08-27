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
         *Độ phức tạp của thuật toán sắp xếp chọn (selection sort) là O(n^2), 
         *trong đó n là số lượng phần tử trong danh sách cần sắp xếp.Thuật toán sắp xếp chọn có hai vòng lặp lồng nhau. 
         *Vòng lặp bên ngoài chạy từ 0 đến n-1, và vòng lặp bên trong chạy từ i+1 đến n. 
         *Với mỗi vòng lặp bên ngoài, cần thực hiện một số lần so sánh và hoán đổi vị trí. 
         *Tổng số lần so sánh và hoán đổi vị trí là (n-1) + (n-2) + ... + 1 = n(n-1)/2, tương đương với O(n^2).
         *Do đó, độ phức tạp của thuật toán sắp xếp chọn là O(n^2), nghĩa là thời gian thực hiện thuật toán tăng theo bình phương số lượng phần tử trong danh sách.
         *link: https://youtube.com/playlist?list=PLprfEn_dJT0_z-A6FlUYjYJVLh4RrmoiZ&si=hPg9ZLn-JZ_t1lXw
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Selection Sort program in C#");

            int[] array = { 100, 50, 20, 40, 10, 60, 80, 70, 90, 30 };

            Console.WriteLine("The array before selection sort is: ");
            foreach (var element in array)
            {
                Console.Write("{0} ", element);
            }

            for (var i = 0; i < array.Length - 1; i++)
            {
                var minIndex = i;

                for (var j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[minIndex])
                    {
                        minIndex = j;
                    }
                }

                if (minIndex != i)
                {
                    array[i] ^= array[minIndex];
                    array[minIndex] ^= array[i];
                    array[i] ^= array[minIndex];
                }
            }

            Console.WriteLine("\nThe array after Selection Sort is: ");
            foreach (var element in array)
            { 
                Console.Write("{0} ", element);
            }

            Console.ReadLine();
        }
    }
}
