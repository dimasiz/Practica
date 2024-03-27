using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 43, 87, 33, 5}; 
            int sumThreshold = 120; 
            int productThreshold = 52;

       
            int sum = 0;
            Parallel.ForEach(numbers, (n, state) =>
            {
                sum += n;
                if (sum > sumThreshold)
                {
                    state.Break();
                }
            });

            Console.WriteLine("Сумма: " + sum);

            
            int product = 1;
            Parallel.ForEach(numbers, (n, state) =>
            {
                product *= n;
                if (product > productThreshold)
                {
                    state.Break();
                }
            });

            Console.WriteLine("Произведение: " + product);
        }
    }
}
