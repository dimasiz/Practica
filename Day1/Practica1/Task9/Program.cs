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
            Console.Write("Введите радиус шара r=");
            double r = Convert.ToDouble(Console.ReadLine());

            double v = 0.75 * Math.PI * Math.Pow(r, 3);
            double s = 4 * Math.PI * Math.Pow(r, 2);

            Console.WriteLine($"Объем шара:{v}");

            Console.WriteLine($"Площадь шара:{s}");
            Console.ReadLine(); 
        }
    }
}
