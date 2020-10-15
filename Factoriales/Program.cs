using System;

namespace Factoriales
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello factorial!");
            int answer = 0;
            answer = Factorial(5);
            Console.WriteLine("Answer is: "+answer);
            bool running = true;
            while (running) { };
        }

        public static int Factorial(int factorialNum)
        {
            if (factorialNum == 1)
            {
                return 1;
            }
            return factorialNum * Factorial(factorialNum - 1);

        }
    }
}
