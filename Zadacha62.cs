using System;

namespace SpiralArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 4;
            int[,] array = new int[n, n];
            int number = 1;
            int row = 0;
            int col = 0;

            while (number <= n * n)
            {
                // Заполнение правой стороны
                while (col < n && array[row, col] == 0)
                {
                    array[row, col] = number++;
                    col++;
                }
                col--;
                row++;

                // Заполнение нижней стороны
                while (row < n && array[row, col] == 0)
                {
                    array[row, col] = number++;
                    row++;
                }
                row--;
                col--;

                // Заполнение левой стороны
                while (col >= 0 && array[row, col] == 0)
                {
                    array[row, col] = number++;
                    col--;
                }
                col++;
                row--;

                // Заполнение верхней стороны
                while (row >= 0 && array[row, col] == 0)
                {
                    array[row, col] = number++;
                    row--;
                }
                row++;
                col++;
            }

            // Вывод массива
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{array[i, j]:00} ");
                }
                Console.WriteLine();
            }
        }
    }
}