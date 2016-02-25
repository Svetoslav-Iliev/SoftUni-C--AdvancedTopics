using System;
using System.Linq;

internal class FillMatrix
{
    private static void Main()
    {
        int rowAndCol = int.Parse(Console.ReadLine());
        char paterntoFillMatrix = (char) Console.Read();

        int[,] matrix = new int[rowAndCol, rowAndCol];
        int startNumber = 1;

        if (Char.ToUpper(paterntoFillMatrix).Equals('A'))
        {
            for (int col = 0; col < rowAndCol; col++)
            {
                for (int row = 0; row < rowAndCol; row++)
                {
                    matrix[row, col] = startNumber;
                    startNumber++;
                }
            }
        }
        else if (Char.ToUpper(paterntoFillMatrix).Equals('B'))
        {
            for (int col = 0; col < rowAndCol; col++)
            {
                if (col%2 == 0)
                {
                    for (int row = 0; row < rowAndCol; row++)
                    {
                        matrix[row, col] = startNumber;
                        startNumber++;
                    }
                }
                else
                {
                    for (int row = rowAndCol - 1; row >= 0; row--)
                    {
                        matrix[row, col] = startNumber;
                        startNumber++;
                    }
                }
            }
        }

        for (int row = 0; row < rowAndCol; row++)
        {
            for (int col = 0; col < rowAndCol; col++)
            {
                Console.Write("{0,2}",matrix[row,col]);
            }
            Console.WriteLine();
        }
    }
}

