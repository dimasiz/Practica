using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread thread1 = new Thread(new ThreadStart(SumMethod));
            Thread thread2 = new Thread(new ThreadStart(SumMethod));
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            thread1.Start();
            Thread.Sleep(100);
            stopwatch.Stop();
            TimeSpan elapsedTime = stopwatch.Elapsed;
            Console.WriteLine("Время выполнения потока 1: " + elapsedTime.TotalMilliseconds + " мс");

            stopwatch.Restart();

            stopwatch.Start();
            thread2.Start();
            Thread.Sleep(100);
            stopwatch.Stop();
            elapsedTime = stopwatch.Elapsed;
            Console.WriteLine("Время выполнения потока 2: " + elapsedTime.TotalMilliseconds + " мс");
        }

        static void SumMethod()
        {
            int avarage = 0;
            for(int i = 0; i <= 10; i++)
            {
                avarage += i;
            }
            Console.WriteLine($"Сумма чисел от 0 до 10: {avarage}");
          
        }
    }
    
}
