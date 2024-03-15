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
            Square square = new Square("Квадрат", 5);
            square.DisplayFields();
            Console.WriteLine($"Площадь: {square.CalculateArea()}");

            Console.WriteLine();
            Rectangle rectangle = new Rectangle("Прямоугольник", 4, 2);
            rectangle.DisplayFields();
            Console.WriteLine($"Площадь: {rectangle.CalculateArea()}");
          
        }
    }
}
