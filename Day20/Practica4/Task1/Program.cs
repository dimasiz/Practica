using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    /// <summary>
    /// Класс, содержащий программу.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Главный метод программы.
        /// </summary>
        /// <param name="args">Аргументы командной строки.</param>
        static void Main(string[] args)
        {
            Console.Write("Введите число=");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine($"Число:{Kalculation(number)}");
            Console.ReadLine();
        }

        /// <summary>
        /// Метод для выполнения вычислений над числом.
        /// </summary>
        /// <param name="number">Входное число.</param>
        /// <returns>Результат вычислений.</returns>
        public static int Kalculation(int number)
        {
            if (number % 5 == 0)
            {
                number /= 5;
            }
            else
            {
                number += 1;
            }
            return number;
        }
    }
}
