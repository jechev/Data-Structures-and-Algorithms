using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02CalculateSequenceWithQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            var startNumber = 2;

            var queue = new Queue<int>();
            queue.Enqueue(startNumber);

            var member = 0;
            int[] startIndex;
            while (true)
            {
                queue.Enqueue(startNumber + 1);

                if (queue.Count == 50)
                {
                    break;
                }

                queue.Enqueue((2 * startNumber) + 1);
                queue.Enqueue(startNumber + 2);

                startIndex = queue.ToArray();
                startNumber = startIndex[member + 1];
                member++;
            }

            foreach (var num in queue)
            {

                Console.Write(num + " ");
            }
        }
    }
}
