using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05CountOfOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();
            SortedDictionary<int, int> numberWithCount = new SortedDictionary<int, int>();
            for (int i = 0; i < input.Count; i++)
            {
                if (numberWithCount.ContainsKey(input[i]))
                {
                    numberWithCount[input[i]]++;
                }
                else
                {
                    numberWithCount.Add(input[i], 1);
                }
            }
            foreach (var number in numberWithCount)
            {
                Console.WriteLine("{0} -> {1} times", number.Key, number.Value);
            }
        }
    }
}
