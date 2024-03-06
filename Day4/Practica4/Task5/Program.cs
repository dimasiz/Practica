using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Program
    {
        public static double F(double x)
        {
            double y = 0;
            if (x <= 5)
            {
                y = Math.Pow(x, 2) + 5;
            }
            else if (5 < x && x < 20)
            {
                y = 0;
            }
            else if (x >= 20)
            {
                y = 1;
            }
            return y;
        }
        public static void  F(double x, out double y )
        {
            y = 0;
           
            if (x <= 5)
            {
                y = Math.Pow(x, 2) + 5;
            }
            else if (5 < x && x < 20)
            {
                y = 0;
            }
            else if (x >= 20)
            {
                y = 1;
            }
            
        }
        static void Main(string[] args)
        {
            Console.Write("Ввидтие a=");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Ввидтие b=");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Ввидтие h=");
            int h = int.Parse(Console.ReadLine());

            for (int i = a; i <= b; i += h)
            {
                Console.WriteLine($"f ={i}, F(i) = {F(i)}");
            }

            for (int i = a; i <= b; i += h)
            {
                double y;
                F(i, out y);
                Console.WriteLine($"Метод с перегрзкой:{y}");
            }

            Console.ReadLine();
        }
    }
}
