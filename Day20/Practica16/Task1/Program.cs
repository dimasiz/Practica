using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    /// <summary>
    /// Внутренний класс программы.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"D:\PracticaC#\Day17\Practica16\Task1\bin\Debug\input.txt";

            if (!File.Exists(filePath))
            {
                Console.WriteLine("Файл не существует.");
                return;
            }

            string[] lines = File.ReadAllLines(filePath);
            double[] numbers = new double[lines.Length];

            for (int i = 0; i < lines.Length - 1; i++)
            {
                numbers[i] = Convert.ToDouble(lines[i]);
            }

            double sum = 0;
            double product = 1;

            foreach (double number in numbers)
            {
                if (number == 0)
                {
                    continue;
                }
                else
                {
                    sum += number;
                    product *= number;
                }
            }

            double sumAbs = Math.Abs(sum);
            double productSquare = product * product;

            Console.WriteLine("Модуль суммы: " + sumAbs);
            Console.WriteLine("Квадрат произведения: " + productSquare);
        }
    }
}