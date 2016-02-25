using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;


class MaximalSum
{
    static void Main()
    {
        Console.Write("Please enter the dimensions of the matrix in format NxM: ");
        string[] matrixDmensions = Console.ReadLine().Split('x').ToArray();

        int matrixRows = int.Parse(matrixDmensions[0]);
        int matrixCols = int.Parse(matrixDmensions[1]);

        int maxSum = int.MinValue;
        int bestRow = 0;
        int bestCol = 1;

        int[,] matrix = new int[matrixRows, matrixCols];

        //Fill the matrix

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            Console.Write("Enter the numbers in the {0} row:", row);
            string[] inputNumbers = Console.ReadLine().Split(' ');
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = int.Parse(inputNumbers[col]);
            }
        }

        //Print the matrix

        Console.WriteLine("This is the matrix you have entered");

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0} ", matrix[row, col]);
            }
            Console.WriteLine();
        }

        //Calculating best sum

        for (int row = 0; row < matrix.GetLength(0) - 2; row++)
        {
            int sum = 0;
            for (int col = 0; col < matrix.GetLength(1) - 2; col++)
            {
                sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] + matrix[row + 1, col] +
                         matrix[row + 1, col + 1] + matrix[row + 1, col + 2] + matrix[row + 2, col] +
                         matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                if (sum > maxSum)
                {
                    maxSum = sum;
                    bestRow = row;
                    bestCol = col;
                }
            }
        }

        //Print the bestSumbMatrix

        Console.WriteLine("The best submatrix sum is: ");

        Console.WriteLine("{0},{1},{2}", matrix[bestRow, bestCol], matrix[bestRow, bestCol + 1], matrix[bestRow, bestCol + 2]);
        Console.WriteLine("{0},{1},{2}", matrix[bestRow + 1, bestCol], matrix[bestRow + 1, bestCol + 1], matrix[bestRow + 1, bestCol + 2]);
        Console.WriteLine("{0},{1},{2}", matrix[bestRow + 2, bestCol], matrix[bestRow + 2, bestCol + 1], matrix[bestRow + 2, bestCol + 2]);

        Console.WriteLine("The best sum is:{0}", maxSum);

    }
}

