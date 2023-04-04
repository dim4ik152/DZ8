using System;

namespace Unique3DArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,,] array = new int[2, 2, 2];

            // Заполнение массива неповторяющимися двузначными числами
            Random random = new Random();
            HashSet<int> usedNumbers = new HashSet<int>();

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    for (int k = 0; k < 2; k++)
                    {
                        int number;
                        do
                        {
                            number = random.Next(10, 100);
                        } while (usedNumbers.Contains(number));
                        usedNumbers.Add(number);
                        array[i, j, k] = number;
                    }
                }
            }

            // Вывод массива построчно с индексами элементов
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    for (int k = 0; k < 2; k++)
                    {
                        Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
}