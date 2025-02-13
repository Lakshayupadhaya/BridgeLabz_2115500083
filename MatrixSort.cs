using System;

class Program
{
    static void Main()
    {
        int[,] matrix = {
            { 5, 3, 8 },
            { 9, 1, 6 },
            { 7, 2, 4 }
        };

        Console.WriteLine("Original Matrix:");
        PrintMatrix(matrix);

        // Sort each row individually
        SortRows(matrix);

        Console.WriteLine("\nMatrix after sorting rows:");
        PrintMatrix(matrix);
    }

    static void SortRows(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < cols; i++)
        {
            // Extract the colm into a temporary array
            int[] tempCol = new int[cols];
            for (int j = 0; j < rows; j++)
            {
                tempCol[j] = matrix[j, i];
            }

            // Sort the row
            Array.Sort(tempCol);

            // Copy sorted row back to the matrix
            for (int j = 0; j < rows; j++)
            {
                matrix[j, i] = tempCol[j];
            }
        }
    }

    static void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
