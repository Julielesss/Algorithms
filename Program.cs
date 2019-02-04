using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FactorialRecursive(5));
            Console.WriteLine(FactorialIterative(5));

        }


        static long FactorialRecursive(uint number)
        {
            if (number == 2)
                return 2;
            if (number < 2)
                return 1;

            return number * FactorialRecursive(--number);
        }


        static long FactorialIterative(uint number)
        {
            if (number < 2)
                return 1;
            if (number == 2)
                return 2;

            long result = number--;
            while (number > 1)
                result *= number--;

            return result;
        }
    }
}
