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
            Console.Write("Введите число=");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine($"Число:{Kalculation(number)}");
            Console.ReadLine();
        }

        public static int Kalculation(int number)
        {
            if(number % 5 == 0)
            {
                number /= 5;
            }
            else
            {
                number += 1;
            }
            return number;
        }
    }
}
