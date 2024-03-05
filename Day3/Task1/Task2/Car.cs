using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Car :Transport
    {
        public int NumWheels { get; set; }
        public string FuelType { get; set; }

        public void HonkTheHorn()
        {
            Console.WriteLine($"Машина:{Model} сигналит");
        }
    }
}
