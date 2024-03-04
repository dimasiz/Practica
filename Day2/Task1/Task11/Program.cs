using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Введите трехзначное число: ");
            int number = int.Parse(Console.ReadLine());

            int firstDigit = number / 100;
            int secondDigit = (number / 10) % 10;
            int thirdDigit = number % 10;

            bool isAscending = firstDigit < secondDigit && secondDigit < thirdDigit;

            if (isAscending)
            {
                Console.WriteLine("Цифры данного трехзначного числа образуют возрастающую последовательность.");
            }
            else
            {
                Console.WriteLine("Цифры данного трехзначного числа не образуют возрастающую последовательность.");
            }

            Console.ReadLine();
        }
    }
}
