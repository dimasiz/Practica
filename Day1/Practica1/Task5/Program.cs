using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите радиус цилиндра R=");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите Высоту цилиндра H=");
            double h = Convert.ToDouble(Console.ReadLine());

            double s = 2 * r * h + 2 * r;
            double v = Math.PI * Math.Pow(r, 2) * h;
            Console.WriteLine($"Площадь цилиндра{s}");
            Console.WriteLine($"Объем цилиндра:{v}");
            Console.ReadLine();
            
        }
    }
}
