using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Express : Train
    {
        public string Destination { get; set; }
        public string DepartureTime { get; set; }

         public void DisplayInfo()
        {
            Console.WriteLine($"Поезд-экспрес{Destination} Отправляеться в {DepartureTime}");
        }

    }
}
