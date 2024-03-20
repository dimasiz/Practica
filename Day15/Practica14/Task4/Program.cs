using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task4
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите количевство потоков");
            int n = int.Parse(Console.ReadLine());

            int[] a = new int[10];
            int count = a.Length /n;

            int start = 0;
            int end = count;

            Random rand = new Random();
            for(int i = 0; i < a.Length; i++)
            {
                a[i] = rand.Next(0,20);
                Console.WriteLine($"Шаг:{i}  Значение:{ a[i]}");
            }

            int avarage = 0;

            for (int i = 0; i < count; i++)
            {
                Task<int> task = Task.Run(() => CalculateProduct(a,start,end));
                avarage += task.Result;
                if(end >= a.Length)
                {
                    break;
                }
                else
                {
                    end += count;
                    start += count;
                    task.Wait(10);
                }
                
            }

            Console.WriteLine($"Сумма посчитанная главным потоком:{ avarage}");
        }

        static int CalculateProduct(int[] a,int start, int end)
        {
            int avarage = 0;

            for (int i = start;i < end; i++)
            {
                if (a[i] % 2 == 0)
                {
                    avarage += a[i];
                }
            }

           return  avarage;
        }
    }
}
