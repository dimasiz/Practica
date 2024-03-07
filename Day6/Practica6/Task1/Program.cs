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
            int[] array = { -1, 2, -3, 4, -5, 6, -7, 8, -9 };

            int positiveCount = 0;

            foreach (int num in array)
            {
                if (num > 0)
                {
                    Console.WriteLine(num);
                    positiveCount++;
                }
            }

            Console.WriteLine("Количество положительных элементов: " + positiveCount);
        }
    }
}
