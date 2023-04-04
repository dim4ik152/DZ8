using System;

namespace MatrixMultiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrixA = new int[,]
            {
                { 3, 6 },
                { 8, 4 }
            };

            int[,] matrixB = new int[,]
            {
                { 2, 32 },
                { 1, 56 }
            };

            int rowsA = matrixA.GetLength(0);
            int columnsA = matrixA.GetLength(1);
            int rowsB = matrixB.GetLength(0);
            int columnsB = matrixB.GetLength(1);

            if (columnsA != rowsB)
            {
                Console.WriteLine("Матрицы не могут быть перемножены.");
            }
            else
            {
                int[,] resultMatrix = new int[rowsA, columnsB];

                for (int i = 0; i < rowsA; i++)
                {
                    for (int j = 0; j < columnsB; j++)
                    {
                        resultMatrix[i, j] = 0;

                        for (int k = 0; k < columnsA; k++)
                        {
                            resultMatrix[i, j] += matrixA[i, k] * matrixB[k, j];
                        }
                    }
                }

                // Вывод результирующей матрицы на экран
                for (int i = 0; i < rowsA; i++)
                {
                    for (int j = 0; j < columnsB; j++)
                    {
                        Console.Write($"{resultMatrix[i, j]} ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}