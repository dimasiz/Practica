using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            string text = "https://www.example.com - пример ссылки, использующей протокол HTTP\nhttps://www.example.com - пример ссылки, использующей протокол HTTPS";
            string pattern = @"(http|https)://([a-zA-Z0-9.-]+)(/)?";

         
            Regex regex = new Regex(pattern);

            
            MatchCollection matches = regex.Matches(text);

            
            foreach (Match match in matches)
            {
                Console.WriteLine($"{match.Value}"); 
            }
        }
    }
}
