using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] matrixDimensions = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

        int rows = matrixDimensions[0];
        int cols = matrixDimensions[1];

        int[,] matrix = new int[rows, cols];

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            int[] rowData = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            for (int col = 0; col < matrix.GetLength(1); col++)
                matrix[row, col] = rowData[col];
        }

        int[,] subMatrix = new int[2, 2];

        int maxSum = int.MinValue;
        int maxRow = 0;
        int maxCol = 0;

        if (matrix.GetLength(0) > 1 && matrix.GetLength(1) > 1)
        {
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    int sum = 0;

                    sum += matrix[row, col];
                    sum += matrix[row, col + 1];
                    sum += matrix[row + 1, col];
                    sum += matrix[row + 1, col + 1];

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        maxRow = row;
                        maxCol = col;
                    }
                }
            }

            for (int row = maxRow; row <= maxRow + 1; row++)
            {
                for (int col = maxCol; col <= maxCol + 1; col++)
                    Console.Write($"{matrix[row, col]} ");

                Console.WriteLine();
            }

            Console.WriteLine(maxSum);
        }
    }
}
