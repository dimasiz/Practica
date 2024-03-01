using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длины сторон треугольника:");
            Console.Write("a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            double p = (a + b + c) / 2; 
            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            double height = (2 * area) / a;  

            Console.WriteLine("Высота треугольника, опущенная на сторону a: " + height);
            Console.ReadKey();
        }
    }
}
