namespace _02_SortArray_SelectionSort
{
    using System;
    using System.Linq;

    class SortArray_SelectionSort
    {
        // Task: Write a program to read an array of numbers from the console, sort them and print them back on the console. 
        // The numbers should be entered from the console on a single line, separated by a space.
        // Solution: I am using BubbleSort.
        static void Main(string[] args)
        {
            string inputData = Console.ReadLine();

            int[] numbers =
                inputData.Trim()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(p => Convert.ToInt32(p))
                    .ToArray();

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] > numbers[j])
                    {
                        // swap elements
                        int buffer = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = buffer;
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
