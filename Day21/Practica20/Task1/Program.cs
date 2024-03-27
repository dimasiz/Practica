using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{


    internal class Program
    {
        public static int SolveAsync(int number)
        {
                int thousands = number / 1000;
                int hundreds = (number / 100) % 10;
                int tens = (number / 10) % 10;
                int units = number % 10;
                int newNumber = thousands * 1000 + tens * 100 + hundreds * 10 + units;

                return newNumber;
        }

        static void Main(string[] args)
        {
            Console.Write("Введите четырехзначеное число:");
            int number = int.Parse(Console.ReadLine());

            Task<int> task1 = new Task<int>(() => SolveAsync(number));

            task1.Start();
            Console.WriteLine($"Ваше переделоное число:{task1.Result}");
            
        }
    }
}
