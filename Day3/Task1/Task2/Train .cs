using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Train : Transport
    {
        public int NumCarriages { get; set; }
        public bool Electric { get; set; }

        public void ChooChoo()
        {
            Console.WriteLine($"Поезд делает чух-чух");
        }
    }
}
