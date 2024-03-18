using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Program
    {
        public delegate double ArithmeticOperation(double x, double y);

        static void Main(string[] args)
        {
            ArithmeticOperation Add = (x, y) => x + y;
            ArithmeticOperation Sub = (x, y) => x - y;
            ArithmeticOperation Mul = (x, y) => x * y;
            ArithmeticOperation Div = (x, y) =>
            {
                if (y != 0)
                    return x / y;
                else
                {
                    Console.WriteLine("Ошибка: деление на ноль!");
                    return double.NaN; 
                }
            };

           
            Console.Write("Введите первое число: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Введите второе число: ");
            double num2 = double.Parse(Console.ReadLine());

           
            Console.WriteLine("Сложение:" + Add(num1, num2));
            Console.WriteLine("Вычитание:" + Sub(num1, num2));
            Console.WriteLine("Умножение:" + Mul(num1, num2));
            Console.WriteLine("Деление:" + Div(num1, num2));
        }
    }
}
