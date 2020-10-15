using System;
using System.Linq;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] arr = { 1, 2, 5, 6, 8, 33, 38 };
            //var res = BinarySearchDisplay(arr,6);
            //Console.WriteLine(res);


            //int[] arr = { −1, −3};


            Console.WriteLine(   sol1(arr));

            Console.ReadLine();
        }

        public static int sol1(int[] A)
        {
            int flag = 1;

            A = A.OrderBy(x => x).ToArray();

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] <= 0)
                    continue;
                else if (A[i] == flag)
                {
                    flag++;
                    Console.WriteLine(flag);
                }

            }
            Console.WriteLine("response: " + flag);
            return flag;
        }

        public static int solution(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            var max = A.Max();
            var min = A.Min();
            Array.Sort(A);
            //   foreach(var item in A)
            //   {
            //       Console.WriteLine(item);
            //   }
            var seed = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > seed)
                {
                    seed++;
                    Console.WriteLine(" seed :" + seed);
                    continue;
                }
                else if (A[i] == seed)
                {
                    seed++;
                    Console.WriteLine(" seed :" + seed);
                    continue;
                }
                else
                {
                    Console.WriteLine(" seed :" + seed);
                    if (i + 1 == A.Length)
                    {
                        return seed++;

                        Console.WriteLine(" seed :" + seed);
                    }

                    return seed;
                }
            }

            return seed;

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
