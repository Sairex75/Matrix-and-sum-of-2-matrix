using System;

namespace _4._8
{
    class Program
    {
        static void Main(string[] args)
        {
            int userLine;
            int userCollumn;
            int matrixSum = 0;

            Random rnd = new Random();

            Console.WriteLine("Введите количество строк в будущей матрице: ");

            userLine = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите количество столбцов в будущей матрице: ");

            userCollumn = int.Parse(Console.ReadLine());

            Console.WriteLine();

            int[,] userMatrix = new int[userLine, userCollumn];

            for (int i = 0; i < userLine; i++)
            {
                for (int j = 0; j < userCollumn; j++)
                {
                    userMatrix[i, j] = rnd.Next(1, 10);
                    Console.Write($"{userMatrix[i, j]} ");
                    matrixSum += userMatrix[i, j];
                }
                Console.WriteLine();
            }

            Console.WriteLine($"\nСумма чисел матрицы: {matrixSum}. Нажмите любую кнопку, чтобы продолжить чудо.");

            Console.ReadLine();

            Console.WriteLine("А вот вам ещё одна матрица такого же размера, но с другими цифрами: \n");

            int[,] secondSameMatrix = new int[userLine, userCollumn];

            for (int i = 0; i < userLine; i++)
            {
                for (int j = 0; j < userCollumn; j++)
                {
                    secondSameMatrix[i, j] = rnd.Next(1, 10);
                    Console.Write($"{secondSameMatrix[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nА вот сумма двух матриц: \n");

            int[,] sumMatrix = new int[userLine, userCollumn];

            for (int i = 0; i < userLine; i++)
            {
                for (int j = 0; j < userCollumn; j++)
                {
                    sumMatrix[i, j] = userMatrix[i,j] + secondSameMatrix[i,j];
                    Console.Write($"{sumMatrix[i, j]} ");
                }
                Console.WriteLine();
            }

        }
    }
}
