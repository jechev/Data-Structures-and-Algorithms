using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01SumAndAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');
            int sum = 0;
            int avg = 0;
            List<int> listWithNumbers = new List<int>();

            foreach (var number in input)
            {
                listWithNumbers.Add(int.Parse(number));
            }

            foreach (var number1 in listWithNumbers)
            {
                sum += number1;
            }
            avg = sum / listWithNumbers.Count();
        }
    }
}
