using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите Текст");

            string s = Console.ReadLine();

            string[] mas = s.Split(' ');

            for (int i = 0; i < mas.Length; i++)
            {
                char[] liter = mas[i].ToCharArray();
                for (int j = 0; j < liter.Length -1; j++)
                {
                    if (liter[j] == liter[j + 1])
                    {
                        Console.WriteLine(liter);
                    }
                }
            }
        }
    }
}
