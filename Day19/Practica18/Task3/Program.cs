using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var trip1 = new Trevel()
            {
                Destination = "Париж",
                StartDate = new DateTime(2024, 4, 1),
                EndDate = new DateTime(2024, 4, 7)
            };
            trip1.AddActivity("Посещение элфелевой башин");
            trip1.AddActivity("Посещение арасака Тавер");

            var trip2 = trip1.Clone() as Trevel;
            trip2.Destination = "Лондон";
            trip2.StartDate = new DateTime(2024, 5, 1);
            trip2.EndDate = new DateTime(2024, 5, 7);
            trip2.RemoveActivity("Музей Лувр");
            trip2.AddActivity("Минская библиотека");

            trip1.PrintInfo();
            Console.WriteLine();

            trip2.PrintInfo();
        }
    }
}
