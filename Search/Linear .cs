namespace Search
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linear  search");
            int[] array = { 1, 2, 3, 4,5,7 };
            int x = 4;
           var kq =   LinearSearch(x, array);

            if (kq != -1)
            {
                Console.WriteLine($"{x}");
            }
            else
            {
                Console.WriteLine($"khong tim thay{x}");
            }
        }
        static int LinearSearch(int x, int[] arr )
        {
            for(int i =0; i < arr.Length; i++)
            {
                if(arr[i] == x )
                {
                    return i;
                }
            }
            return -1; // khong tim ra x 
        }
    }
}