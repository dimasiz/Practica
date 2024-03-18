using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class Program
    {
        public delegate int RandomDelegate();
        static void Main(string[] args)
        {
            RandomDelegate[] delegates = new RandomDelegate[5];

            Random random = new Random();

            for (int i = 0; i < delegates.Length; i++)
            {
                delegates[i] = () => random.Next(0, 100);
            }

            int average = GetAverage(delegates);
            Console.WriteLine("Среднее арифметическое:" + average);
        }


        public static int GetAverage(RandomDelegate[] delegates)
        {
            int sum = 0;
            foreach (RandomDelegate del in delegates)
            {
                sum += del();
            }
            return sum;
        }
    }
}
