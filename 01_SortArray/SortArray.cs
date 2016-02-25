namespace _01_SortArray
{
    using System;
    using System.Linq;

    internal class SortArray
    {
        // Task: Write a program to read an array of numbers from the console, sort them and print them back on the console. 
        // The numbers should be entered from the console on a single line, separated by a space.
        // Solution: I am using SelectionSort.
        private static void Main(string[] args)
        {
            string inputData = Console.ReadLine();

            int[] numbers =
                inputData.Trim()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(p => Convert.ToInt32(p))
                    .ToArray();

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = 0; j < numbers.Length - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        // swap elements
                        int tmp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = tmp;
                    }
                }
            }

            foreach (var number in numbers)
            {
                Console.WriteLine(string.Join(" ", number));
            }
        }
    }
}