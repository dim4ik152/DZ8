using System;

namespace SortArrayRowsDescending
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[,]
            {
                { 1, 5, 3, 4 },
                { 10, 6, 7, 8 },
                { 9, 2, 11, 12 }
            };

            int rows = array.GetLength(0);
            int columns = array.GetLength(1);

            // Сортировка элементов каждой строки массива по убыванию
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    for (int k = j + 1; k < columns; k++)
                    {
                        if (array[i, j] < array[i, k])
                        {
                            int temp = array[i, j];
                            array[i, j] = array[i, k];
                            array[i, k] = temp;
                        }
                    }
                }
            }

            // Вывод отсортированного массива на экран
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}