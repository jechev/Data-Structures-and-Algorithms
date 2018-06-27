using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02SortWords
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            List<string> words = new List<string>();
            if (input.Length > 0)
            {
                var inputWords = input.Split(' ');
                foreach (var word in inputWords)
                {
                    words.Add(word);
                }
            }
            words.Sort();
            Console.WriteLine(String.Join(" ", words));
        }
    }
}
