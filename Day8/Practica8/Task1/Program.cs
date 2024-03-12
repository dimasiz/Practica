using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Пример текста с номерами телефонов: 9 234 567 89 12, 12345678912, +1 234 567 89 12, 1-234-567-89-12. Лалал 345446 Огонь 82";
            string pattern = @"\b?([+\s])\d{1}[-\s]?(\d{3}[-\s]?){2}\d{2}[-\s]?\d{2}\b";


            MatchCollection matches = Regex.Matches(text, pattern);

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}
