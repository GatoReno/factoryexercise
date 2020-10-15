using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static object BinarySearchDisplay(int[] arr, int item)
        {
            int first = 0;
            int last = arr.Length - 1;
            int mid = 0;

            do
            {
                mid = first + (last - first) / 2;
                if (item > arr[mid])
                    first = mid + 1;
                else
                    last = mid - 1;
                if (arr[mid] == item)
                    return mid;
            } while (first <= last);
            return mid;
        }

    }

   
}
