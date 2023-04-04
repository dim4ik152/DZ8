using System;

namespace FindRowWithSmallestSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[,]
            {
                { 1, 5, 7, 2 },
                { 5, 3, 2, 3 },
                { 8, 8, 3, 4 },
                { 5, 2, 2, 7 }
            };

            int rows = array.GetLength(0);
            int columns = array.GetLength(1);

            int minSumRowIndex = 0;
            int minSum = int.MaxValue;

            for (int i = 0; i < rows; i++)
            {
                int rowSum = 0;

                for (int j = 0; j < columns; j++)
                {
                    rowSum += array[i, j];
                }

                if (rowSum < minSum)
                {
                    minSum = rowSum;
                    minSumRowIndex = i;
                }
            }

            Console.WriteLine($"Строка с наименьшей суммой элементов: {minSumRowIndex + 1}");
        }
    }
}