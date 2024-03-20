using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Thread thread1 = new Thread(new ThreadStart(FirstThread));
            Thread thread2 = new Thread(new ThreadStart(SecondThread));
            Thread thread3 = new Thread(new ThreadStart(ThirdThread));

            thread1.Priority = ThreadPriority.Highest;
            thread2.Priority = ThreadPriority.Normal;
            thread3.Priority = ThreadPriority.Lowest;

            thread1.Start();
            Thread.Sleep(100);
            thread2.Start();
            Thread.Sleep(100);
            thread3.Start();

        }
        static void FirstThread()
        {
            for (int i = 0; i < 10; i++)
            { 
                Console.WriteLine($"Первый поток:{i}");
            }
        }
        static void SecondThread()
        {
            for (int i = 10; i < 20; i++)
{
                Console.WriteLine($"Второй поток:{i}");
            }
        }
        static void ThirdThread()
        {
            for (int i = 20; i < 30; i++)
            {
                Console.WriteLine($"Третий поток:{i}");
            }
        }
    }
}
