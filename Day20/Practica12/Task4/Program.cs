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
        /// Делегат для генерации случайных чисел.
        /// </summary>
        /// <returns>Случайное число.</returns>
        public delegate int RandomDelegate();

        /// <summary>
        /// Точка входа в программу.
        /// </summary>
        /// <param name="args">Аргументы командной строки.</param>
        static void Main(string[] args)
        {
            RandomDelegate[] delegates = new RandomDelegate[5];

            Random random = new Random();

            for (int i = 0; i < delegates.Length; i++)
            {
                delegates[i] = () => random.Next(0, 100);
            }

            int average = GetAverage(delegates);
            Console.WriteLine("Среднее арифметическое: " + average);
        }

        /// <summary>
        /// Метод для вычисления среднего арифметического значения, возвращаемого делегатами.
        /// </summary>
        /// <param name="delegates">Массив делегатов для генерации случайных чисел.</param>
        /// <returns>Среднее арифметическое значение.</returns>
        public static int GetAverage(RandomDelegate[] delegates)
        {
            int sum = 0;
            foreach (RandomDelegate del in delegates)
            {
                sum += del();
            }
            return sum / delegates.Length;
        }
    }
}