using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            A objA = new A(10, 20);

            Console.WriteLine("Значения полей класса A: a = " + objA.AValue + ", b = " + objA.BValue);
            Console.WriteLine();

            B objB1 = new B(25, 34, 90);
            Console.WriteLine("Значения полей класса B (конструктор 1): a = " + objB1.AValue + ", b = " + objB1.BValue + ", d = " + objB1.DValue);
            Console.WriteLine("Значение свойства C2: " + objB1.C2);
            Console.WriteLine();

            B objB2 = new B(10, 20, 30, 40);
            Console.WriteLine("Значения полей класса B (конструктор 2): a = " + objB2.AValue + ", b = " + objB2.BValue + ", d = " + objB2.DValue);
            Console.WriteLine("Значение свойства C2: " + objB2.C2);
            Console.WriteLine();
        }
    }
}
