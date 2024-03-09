using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Program
    {
        static double CalculateF(int n)
        {
            if (n == 1)
            {
                return 1; 
            }
            else
            {
                return 1.0 / ((n + 3) * CalculateF(n - 1));
            }
        }

        static void Main()
        {
          
            Console.Write("Введите значение n: ");
            int n = int.Parse(Console.ReadLine());

         
            double result = CalculateF(n);

          
            Console.WriteLine($" f = {n}, f = ({result})");
        }
    }
}
