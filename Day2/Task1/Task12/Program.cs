using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целое число N (N > 0): ");
            int N = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = N; i <= 2 * N; i++)
            {
                sum += i * i;
            }

            Console.WriteLine("Сумма выражения: " + sum);

            Console.ReadLine();

        }
    }
}
