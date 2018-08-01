using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02RecursiveFactorial
{
    class RecursiveFactorial
    {
        static void Main(string[] args)
        {
           string input = Console.ReadLine();
           long number = long.Parse(input);
           long result = SumFactorial(number);

        }

        private static long SumFactorial(long number)
        {
            if (number == 0)
            {
                return 1;
            }

            return number * SumFactorial(number - 1);
        }
    }
}
