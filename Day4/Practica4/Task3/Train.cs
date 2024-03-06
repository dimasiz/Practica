using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Train
    {
        private string destination;
        private string trainNumber;
        private DateTime departureTime;

        public Train(string destination, string trainNumber, DateTime departureTime)
        {
            this.destination = destination;
            this.trainNumber = trainNumber;
            this.departureTime = departureTime;
            Stayt = true;
        }

        public string Destination { get; set; }
        public string TrainNumber { get; set; }
        public DateTime DepartureTime { get; set;  }

        public bool Stayt { get; set; }
       

        public void DisplayTrainInfo()
        {
            Console.WriteLine($"Путь: {destination}");
            Console.WriteLine($"Номер поезда:{trainNumber}");
            Console.WriteLine($"время отъезда: {departureTime}");
            Console.WriteLine($"Поезд работтает исправно:{Stayt}");
        }

        public void DisplayTrainBroken(bool broke)
        {
            Console.WriteLine("Поезд сломан");
            Stayt = broke;
        }

        public void DisplayTrainBroken(bool broke,DateTime data)
        {
            Console.WriteLine($"Поезд сломан в {data}");
        }
    }
}
