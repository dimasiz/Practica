using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a=");
            double a = Convert.ToDouble(Console.ReadLine());
            string formattedANumber = $"{a:N4}";
            Console.Write("b=");
            double b = Convert.ToDouble(Console.ReadLine());
            string formattedBNumber = $"{b:N4}";
            Console.Write("c=");
            double c = Convert.ToDouble(Console.ReadLine());
            string formattedCNumber = $"{c:N4}";

            Console.WriteLine($"{formattedANumber}+({formattedBNumber}+{formattedCNumber}) = {formattedANumber}+{formattedCNumber}+{formattedBNumber}");
            Console.ReadLine();
        }
    }
}
