using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07ReverseNumbersWithStack
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();

            Stack<int> stackWithNumbers = new Stack<int>();
            foreach (var number in input)
            {
                stackWithNumbers.Push(number);
            }

            var output = "";
            foreach (var numberInStack in stackWithNumbers)
            {
                output += " " + numberInStack;
            }
            Console.WriteLine(output.Trim());
        }
    }
}
