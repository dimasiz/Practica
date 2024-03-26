using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    /// <summary>
    /// Главный класс программы.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Делегат для обработки операций со строкой.
        /// </summary>
        /// <param name="text">Входная строка.</param>
        public delegate void StringAction(string text);

        /// <summary>
        /// Точка входа в программу.
        /// </summary>
        /// <param name="args">Аргументы командной строки.</param>
        static void Main(string[] args)
        {
            StringAction stringAction;

            stringAction = ReverseString;
            stringAction += UppercaseString;
            stringAction += LowercaseString;

            stringAction("Hello world!");
        }

        /// <summary>
        /// Метод для обращения строки.
        /// </summary>
        /// <param name="text">Входная строка.</param>
        public static void ReverseString(string text)
        {
            char[] charArray = text.ToCharArray();
            Array.Reverse(charArray);
            string reversedText = new string(charArray);
            Console.WriteLine("Обратная строка: " + reversedText);
        }

        /// <summary>
        /// Метод для преобразования строки в верхний регистр.
        /// </summary>
        /// <param name="text">Входная строка.</param>
        public static void UppercaseString(string text)
        {
            string uppercaseText = text.ToUpper();
            Console.WriteLine("Строка в верхнем регистре: " + uppercaseText);
        }

        /// <summary>
        /// Метод для преобразования строки в нижний регистр.
        /// </summary>
        /// <param name="text">Входная строка.</param>
        public static void LowercaseString(string text)
        {
            string lowercaseText = text.ToLower();
            Console.WriteLine("Строка в нижнем регистре: " + lowercaseText);
        }
    }
}