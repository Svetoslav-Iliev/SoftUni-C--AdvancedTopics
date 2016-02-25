namespace _03_CategorizeNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class CategorizeNumbers
    {
        static void Main(string[] args)
        {
            // Task: Write a program that reads N floating-point numbers from the console. 
            // Your task is to separate them in two sets, one containing only the round numbers (e.g. 1, 1.00, etc.) 
            // and the other containing the floating-point numbers with non-zero fraction. 
            // Print both arrays along with their minimum, maximum, sum and average (rounded to two decimal places).
            string inputData = Console.ReadLine();

            decimal[] numbers =
                inputData.Trim()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(p => Convert.ToDecimal(p))
                    .ToArray();

            
            HashSet<decimal> decimalNumbers = new HashSet<decimal>();
            HashSet<int> integerNumbers = new HashSet<int>();

            foreach (var number in numbers)
            {
                int roundedNumber = (int)number;
                if (number - roundedNumber == 0)
                {
                    integerNumbers.Add((int)number);
                }
                else
                {
                    decimalNumbers.Add(number);
                }

            }

            PrintDecimalResult(decimalNumbers);
            PrintIntegerNumber(integerNumbers);
        }

        private static void PrintDecimalResult(HashSet<decimal> decimalNumbers)
        {
            Console.Write("[" + string.Join(", ", decimalNumbers) + "]");
            Console.WriteLine(
                " -> min: {0}, max: {1}, sum: {2}, avg: {3:F2}", 
                decimalNumbers.Min(), 
                decimalNumbers.Max(), 
                decimalNumbers.Sum(), 
                decimalNumbers.Average());
        }
        private static void PrintIntegerNumber(HashSet<int> integerNumbers)
        {
            Console.Write("[" + string.Join(", ", integerNumbers) + "]");
            Console.WriteLine(
                " -> min: {0}, max: {1}, sum: {2}, avg: {3:F2}",
                integerNumbers.Min(),
                integerNumbers.Max(),
                integerNumbers.Sum(),
                integerNumbers.Average());
        }
    }
}
