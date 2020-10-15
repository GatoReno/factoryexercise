using System;
using System.Linq;

namespace ClosestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] arr = { 1, 2, 3, 4, 5, 6 };
            
            var x = SumRange(arr, 0, 5);
            Console.ReadLine();
        }

        
        public void SumRange_Test(int[] arr, int n1, int n2)
        {
            int expected = 21;
            var actual = SumRange(arr, n1, n2);
             // Assert.Equal(expected, actual);
        }
      
        public int SumRange(int[] arr, int n1, int n2)
        {
            if (n1 < 0 && n1 > n2 && n1 > arr.Length)
                return 0;
            var x = arr[n1..(n2 + 1)].Sum();
            return x;
        }
    }
}
