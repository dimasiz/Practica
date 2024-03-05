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
            Car car = new Car()
            {
                Model = "Audi A4",
                Year = 2022,
                MaxSpeed = 200,
                NumWheels = 4,
                FuelType = "Бензин"
            };

            car.Move();
            car.HonkTheHorn();

            Train train = new Train()
            {
                Model = "Пассажирский поезд",
                Year = 2010,
                MaxSpeed = 120,
                NumCarriages = 10,
                Electric = false
            };

            train.Move();
            train.ChooChoo();

            Express express = new Express()
            {
                Model = "экспрес поезд",
                Year = 2023,
                MaxSpeed = 180,
                NumCarriages = 6,
                Electric = true,
                Destination = "Минск",
                DepartureTime = "10:00"
            };

            express.Move();
            express.ChooChoo();
            express.DisplayInfo();

            Console.ReadLine();
        }
    }
}
