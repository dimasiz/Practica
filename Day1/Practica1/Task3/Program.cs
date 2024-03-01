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
            Console.Write("Введите X:=");
            double x = Convert.ToDouble(Console.ReadLine()) ;
            double y = 2 * Math.PI / 2 - Math.Atan(1 - Math.Sqrt(x)) + (Math.Log10(7 * x) / 1 +Math.Pow(Math.E, x));
            Console.WriteLine(y);
            Console.ReadLine();

        }
    }
}
