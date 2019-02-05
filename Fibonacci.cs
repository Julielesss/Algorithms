using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Fibonacci
    {
        static void Main(string[] args)
        {
           Console.WriteLine(FibonacciNumber(12));
           Console.WriteLine(FibonacciNumberIterative(12));

        }


        static long FibonacciNumber(uint n)
        {
            if (n == 1 || n == 2)
                return 1;
            if (n == 0)
                return 0;

            return FibonacciNumber(n-1) + FibonacciNumber(n - 2);

        }


        static long FibonacciNumberIterative(uint n)
        {
            if (n == 0 || n == 1)
                return n;
            if (n == 2)
                return 1;

            long result = 1;
            long prev = 1;

            while (n > 2)
            {
                result += prev;
                prev = result - prev;
                --n;
            }
            return result;
        }
    }
}
