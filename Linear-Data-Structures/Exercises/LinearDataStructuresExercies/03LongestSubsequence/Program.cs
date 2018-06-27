using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03LongestSubsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            int countSequence = 0;
            int counter = 0;
            int equalNumber = int.MinValue;
            List<int> listWithNumbers = new List<int>();
            if (input.Length > 0)
            {
                var inputNumbers = input.Split(' ');
                if (inputNumbers.Length == 1)
                {
                    listWithNumbers.Add(int.Parse(inputNumbers[0]));
                }
                else
                {
                    foreach (var number in inputNumbers)
                    {
                        ++counter;
                        if (countSequence == 0)
                        {
                            countSequence++;
                            equalNumber = int.Parse(number);

                        }
                        else
                        {
                            if (equalNumber == int.Parse(number))
                            {
                                countSequence++;
                            }
                            if (equalNumber != int.Parse(number) || counter == inputNumbers.Length)
                            {
                                if (listWithNumbers.Count() < countSequence)
                                {
                                    if (listWithNumbers.Count() > 0)
                                    {
                                        listWithNumbers.Clear();
                                    }
                                    for (int i = 0; i < countSequence; i++)
                                    {
                                        listWithNumbers.Add(equalNumber);
                                    }
                                }
                                countSequence = 1;
                                equalNumber = int.Parse(number);
                            }
                        }

                    }
                }

            }

            Console.WriteLine(String.Join(" ", listWithNumbers));
        }
    }
}
