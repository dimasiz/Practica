using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    /// <summary>
    /// Класс, представляющий поезд.
    /// </summary>
    public class Train
    {
        private string destination;
        private string trainNumber;
        private DateTime departureTime;

        /// <summary>
        /// Конструктор класса Train.
        /// </summary>
        /// <param name="destination">Пункт назначения.</param>
        /// <param name="trainNumber">Номер поезда.</param>
        /// <param name="departureTime">Время отправления.</param>
        public Train(string destination, string trainNumber, DateTime departureTime)
        {
            this.destination = destination;
            this.trainNumber = trainNumber;
            this.departureTime = departureTime;
            Stayt = true;
        }

        /// <summary>
        /// Пункт назначения поезда.
        /// </summary>
        public string Destination { get; set; }

        /// <summary>
        /// Номер поезда.
        /// </summary>
        public string TrainNumber { get; set; }

        /// <summary>
        /// Время отправления поезда.
        /// </summary>
        public DateTime DepartureTime { get; set; }

        /// <summary>
        /// Флаг, указывающий, находится ли поезд в рабочем состоянии.
        /// </summary>
        public bool Stayt { get; set; }

        /// <summary>
        /// Метод для отображения информации о поезде.
        /// </summary>
        public void DisplayTrainInfo()
        {
            Console.WriteLine($"Пункт назначения: {destination}");
            Console.WriteLine($"Номер поезда: {trainNumber}");
            Console.WriteLine($"Время отправления: {departureTime}");
            Console.WriteLine($"Поезд работает исправно: {Stayt}");
        }

        /// <summary>
        /// Метод для отображения информации о сломанном поезде.
        /// </summary>
        /// <param name="broke">Флаг, указывающий, сломан ли поезд.</param>
        public void DisplayTrainBroken(bool broke)
        {
            Console.WriteLine("Поезд сломан");
            Stayt = broke;
        }

        /// <summary>
        /// Метод для отображения информации о сломанном поезде в указанное время.
        /// </summary>
        /// <param name="broke">Флаг, указывающий, сломан ли поезд.</param>
        /// <param name="data">Время поломки поезда.</param>
        public void DisplayTrainBroken(bool broke, DateTime data)
        {
            Console.WriteLine($"Поезд сломан в {data}");
        }
    }
}
