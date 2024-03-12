using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Пример текста с номерами телефонов: 3453463464363, 3443534, 1234567, 123-4567, +7 (123) 456-7890, 9876543, 123456789";

            string pattern = @"\b\d{7}\b";

            MatchCollection matches = Regex.Matches(text, pattern);
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}
