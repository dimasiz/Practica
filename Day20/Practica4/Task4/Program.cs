using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    /// <summary>
    /// Главный класс программы.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Функция F(x) для вычисления значения y.
        /// </summary>
        /// <param name="x">Аргумент функции.</param>
        /// <returns>Значение функции.</returns>
        public static double F(double x)
        {
            double y = 0;
            if (x <= 5)
            {
                y = Math.Pow(x, 2) + 5;
            }
            else if (5 < x && x < 20)
            {
                y = 0;
            }
            else if (x >= 20)
            {
                y = 1;
            }
            return y;
        }

        /// <summary>
        /// Точка входа в программу.
        /// </summary>
        /// <param name="args">Аргументы командной строки.</param>
        static void Main(string[] args)
        {
            Console.Write("Введите a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите b: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Введите h: ");
            int h = int.Parse(Console.ReadLine());

            for (int i = a; i <= b; i += h)
            {
                Console.WriteLine($"f({i}) = {F(i)}");
            }

            Console.ReadLine();
        }
    }
}