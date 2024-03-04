using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину прямоугольника: ");
            double length = double.Parse(Console.ReadLine());

            Console.Write("Введите ширину прямоугольника: ");
            double width = double.Parse(Console.ReadLine());

            double perimeter = 2 * (length + width);
            double diagonal = Math.Sqrt(length * length + width * width);

            Console.WriteLine("Периметр прямоугольника: " + perimeter);
            Console.WriteLine("Длина диагонали прямоугольника: " + diagonal);

            Console.ReadLine();
        }
    }
}
