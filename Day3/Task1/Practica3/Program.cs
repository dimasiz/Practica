using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите a=");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Введите b=");
            int b = int.Parse(Console.ReadLine());

            double kube = Cubing(a,b);
            double kulculation = Kalculation(a,b);

            Console.WriteLine($"Метод возведения в куб:{kube}\nMетод решение выражения:{kulculation}");
            Console.ReadLine();
        }

        public static double Kalculation(int a, int b)
        {
            double answer = ((3 * b) - (2 / Math.Pow(a,2)))/ 4;

            return answer;
        }

        public static double Cubing(int a, int b)
        {
            double answer = Math.Pow(a - b, 3);
            return answer;
        }
    }
}
