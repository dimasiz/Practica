using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Trevel : Prototype
    {
        public override void PrintInfo()
        {
            Console.WriteLine("Подробности поездки:");
            Console.WriteLine("Место назначения: " + Destination);
            Console.WriteLine("Начало поездки: " + StartDate.ToShortDateString());
            Console.WriteLine("Конец поездки: " + EndDate.ToShortDateString());
            Console.WriteLine("Развалечение: ");
            foreach (var activity in Activities)
            {
                Console.WriteLine("- " + activity);
            }
        }
    }
}
