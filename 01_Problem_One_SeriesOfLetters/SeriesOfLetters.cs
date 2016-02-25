using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


class SeriesOfLetters
{
    static void Main()
    {
        var input = Console.ReadLine();
        Console.WriteLine(LetterReplacment(input));
    }

    private static string LetterReplacment(string input)
    {
        string pattern = "(.)\\1+";
        Regex regex = new Regex(pattern);

        return regex.Replace(input, "$1");
    }
}

