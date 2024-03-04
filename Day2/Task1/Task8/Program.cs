using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Двузначные числа, равные утроенному произведению своих цифр:");

            for (int number = 10; number < 100; number++)
            {
                int product = GetDigitProduct(number);

                if (number == 3 * product)
                {
                    Console.WriteLine(number);
                }
            }

            Console.ReadLine();
        }

       public static int GetDigitProduct(int number)
       {
            int product = 1;

            while (number > 0)
            {
                int digit = number % 10;
                product *= digit;
                number /= 10;
            }

            return product;
       }
    }
}
