using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите Текст");
            
            string s = Console.ReadLine();

            string[] mas = s.Split(' ');

            foreach (var word in mas)
            {
                char[] liter = word.ToCharArray();
                if (char.IsLower(liter[0]))
                {
                    Console.WriteLine(word);
                }
            }
        }
    }
}
