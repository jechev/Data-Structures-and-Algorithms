using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03RecursiveDrawing
{
    class RecursiveDrawing
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int number = int.Parse(input);
            Drawing(number);
        }

        private static void Drawing(int n)
        {
            if (n <= 0)
            {
                return;
            }
            Console.WriteLine(new string('*',n));
            Drawing(n - 1);
            Console.WriteLine(new string('#',n));
        }
    }
}
