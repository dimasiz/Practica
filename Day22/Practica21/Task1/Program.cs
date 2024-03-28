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
            ChocolateBoiler boiler = ChocolateBoiler.GetInstance();

            boiler.Fill();

            bool isEmpty = boiler.IsEmpty();
            Console.WriteLine("Бойлер заполнен: " + isEmpty);

            boiler.Drain();

            isEmpty = boiler.IsEmpty();
            Console.WriteLine("Бойлер заполнен: " + isEmpty);
        }
    }
}
