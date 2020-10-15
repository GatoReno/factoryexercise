using System;
using System.Linq;

namespace CoinProblem
{
    class Program
    {
        public static int amount = 20;
        public static int[] coins = { 2, 5, 10 };
        //public int n = coins.Sum();

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! calc "+amount.ToString());

            // var x = Resolve(amount, coins, n);


            var x = combo(amount);
            Console.WriteLine("s: "+x);
         
            Console.ReadLine();

        }

        public static int combo(int amount)
        {
            int nCombos = 0;

            if (amount == 0)
            {
                return 1;
            }

            if (amount < 0)
            {
                return 0;
            }

            for (int i = 0; i < coins.Length; i++)
             {
                Console.WriteLine(i + " : "+ (amount - coins[i]).ToString());
                nCombos += combo(amount - coins[i]);
            }

            return nCombos;
        }

        //public static int Resolve(int amount, int[] coins, int n)
        //{
        //    if (n == 0) {Console.WriteLine("no coins neeed"); return 1; }
        //    if (amount <= 0 && n >= 1) { Console.WriteLine("no coins neeed"); return 0; }

        //    return Resolve(amount - 1,coins, n) +
        //    Resolve(amount,coins, n - coins[amount - 1]);

        //}

        public class Change
        {
            public long coin2 = 0;
            public long bill5 = 0;
            public long bill10 = 0;
        }

    }

}
