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
            var input = Console.ReadLine();
            int sum = 0;
            double avg = 0;
            List<int> listWithNumbers = new List<int>();
            if (input.Length > 0)
            {
                var inputNumbers = input.Split(' ');
                foreach (var number in inputNumbers)
                {
                    listWithNumbers.Add(int.Parse(number));
                }

                foreach (var number1 in listWithNumbers)
                {
                    sum += number1;
                }
                avg = Convert.ToDouble(sum) / listWithNumbers.Count();
            }
            
            Console.WriteLine("Sum={0}; Average={1:0.00}", sum,avg);
        }
    }
}
