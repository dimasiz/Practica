using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            Console.Write("Введите a=");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Введите b=");
            int b = int.Parse(Console.ReadLine());

            A demonstration = new A(a,b);

            double kube = demonstration.Cubing(a,b);
            double kulculation = demonstration.Kalculation(a,b);

            Console.WriteLine($"Метод возведения в куб:{kube}\nMетод решение выражения:{kulculation}");
            
            Console.ReadLine();
        }

     
    }
}
