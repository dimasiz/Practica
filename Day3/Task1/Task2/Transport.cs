using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
        public class Transport
        {
            public string Model { get; set; }
            public int Year { get; set; }
            public int MaxSpeed { get; set; }

        public void Move()
        {
            Console.WriteLine($"{Model} едeт со скоростью:{MaxSpeed}");
        }
    }
    
}
