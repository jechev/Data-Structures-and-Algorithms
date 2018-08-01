using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Generating01Vectors
{
    class Generating01Vectors
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int number = int.Parse(input);
            int[] arr = new int[number];
            Gen01(arr, 0);

        }
        private static void Gen01(int[] vector,int index)
        {
            if (index == vector.Length)
            {
                Console.WriteLine(string.Join(" ",vector));
            }
            else
            {
                for (int i = 0; i <= 1; i++)
                {
                    vector[index] = i;
                    Gen01(vector, index + 1);
                }
            }

        }
    }
}
