namespace _01RecursiveArraySum
{
    class ArraySum
    {
        static void Main(string[] args)
        {
            int[] arrWithNumbers = new int[5] { 4, 3, 2, 1, 4 };
            System.Console.WriteLine(SumArr(arrWithNumbers,0));

        }

        private static int SumArr(int[] array,int index)
        {
            if (index == array.Length -1)

            {
                return array[index];
            }

            return array[index] + SumArr(array, index + 1);

        }
    }
}
