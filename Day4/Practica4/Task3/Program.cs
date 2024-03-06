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
            Train train = new Train("Москва", "9.3/4", new DateTime(2024, 3, 6, 10, 30, 0));
            train.DisplayTrainInfo();
            train.DisplayTrainBroken(true);
            train.DisplayTrainBroken(true, new DateTime(2024, 3, 5, 10, 30, 0));
            

            Console.ReadLine();
        }
    }
}
