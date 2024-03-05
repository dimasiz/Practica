using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cyrcle circle = new Cyrcle(5, 6, 8);

            
            double radius = circle.Radius;
            double x = circle.X;
            double y = circle.Y;

          
            double area = circle.GetArea();
            double circumference = circle.GetLengthCyrcle();

            Console.WriteLine($"Круг:Радиус={radius}, Центер в точке{x},{y}");
            Console.WriteLine($"Площадь:{area}");
            Console.WriteLine($"Длинна окружности:{circumference}");

           
            double pointX = 2;
            double pointY = 2;
            bool isInside = circle.IsPointInside(pointX, pointY);
            Console.WriteLine($"Точка {pointX}, {pointY} Лежит в круге:{isInside}");

            Console.ReadLine();
        }
    }
}
