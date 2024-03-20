using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число A:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите количество потоков N:");
            int n = int.Parse(Console.ReadLine());

            
            Thread thread1 = new Thread(() => CalculateSum(a, n));
            Thread thread2 = new Thread(() => CalculateSum(a, n));

            thread1.Start();
            thread2.Start();

            thread1.Join();
            thread2.Join();

          
            
            for (int i = 0; i < n; i++)
            {
                Thread thread = new Thread(() => CalculateProduct(a, n));
                thread.Start();
                thread.Join();
            }

           
        }

        static void CalculateSum(int A, int N)
        {
            int sum = 0;

            for (int i = 1; i <= N; i++)
            {
                sum += A * i;
            }

            Console.WriteLine("Сумма: " + sum);
        }

        static void CalculateProduct(int A, int N)
        {
            int product = 1;

            for (int i = 1; i <= N; i++)
            {
                product *= A * i;
            }

            Console.WriteLine("Произведение: " + product);
        }
    }
}
