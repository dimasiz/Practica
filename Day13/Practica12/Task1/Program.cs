using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Program
    {
        public delegate double CalcFigure(double radius);

       
        public static double Get_Length(double radius)
        {
            return 2 * Math.PI * radius;
        }

        public static double Get_Area(double radius)
        {
            return Math.PI * radius * radius;
        }

        public static double Get_Volume(double radius)
        {
            return (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);
        }
        static void Main(string[] args)
        {
            CalcFigure CF;

            CF = Get_Length;
            Console.WriteLine("Длина окружности:" + CF(5));

            CF = Get_Area;
            Console.WriteLine("Площадь круга:" + CF(5));

            CF = Get_Volume;
            Console.WriteLine("Объем шара:" + CF(5));
        }
    }
}
