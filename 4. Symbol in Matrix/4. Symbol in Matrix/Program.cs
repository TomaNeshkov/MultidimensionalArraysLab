using System;

class Program
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());

        char[,] matrix = new char[size, size];

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            string rowData = Console.ReadLine();

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = rowData[col];
            }
        }

        char symbolToFind = char.Parse(Console.ReadLine());

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if (matrix[row, col] == symbolToFind)
                {
                    Console.WriteLine($"({row}, {col})");
                    return;
                }
            }
        }

        Console.WriteLine($"{symbolToFind} does not occur in the matrix");
    }
}
