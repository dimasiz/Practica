using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите натуральное число: ");
            int number = int.Parse(Console.ReadLine());

            int smallestDigit = 9;
            int largestDigit = 0;

            while (number > 0)
            {
                int digit = number % 10;
                smallestDigit = Math.Min(smallestDigit, digit);
                largestDigit = Math.Max(largestDigit, digit);
                number /= 10;
            }

            Console.WriteLine("Наименьшая цифра: " + smallestDigit);
            Console.WriteLine("Наибольшая цифра: " + largestDigit);

            Console.ReadLine();
        }
    }
    }

