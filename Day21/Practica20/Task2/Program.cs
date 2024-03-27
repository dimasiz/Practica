using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {

        public static double Solution1(int m, int n)
        {
           return ((m-1) * Math.Sqrt(m) - (n -1) * Math.Sqrt(n))/Math.Sqrt(Math.Pow(m,3)* n) + n * m + Math.Pow(n,2) - m;

        }

        public static double Solution2(int m, int n) 
        {
            return (Math.Sqrt(m) - Math.Sqrt(n)) / m;
        }
        static void Main(string[] args)
        {
            Console.Write("Введите M:");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Введите N:");
            int n = int.Parse(Console.ReadLine());
            Task[] tasks = new Task[2];

         
            tasks[0] = Task.Run(() =>
            {
                Console.WriteLine($"Задача 1 запущена c параметрами N:{n} M:{m}");
                double answer = Solution1(m,n);
                Thread.Sleep(2000); 
                Console.WriteLine($"Задача 1 завершена c результатом:{answer}");
            });

            
            tasks[1] = Task.Run(() =>
            {
                Console.WriteLine($"Задача 1 запущена c параметрами N:{n} M:{m}");
                double answer = Solution2(m, n);
                Thread.Sleep(3000);
                Console.WriteLine($"Задача 1 завершена c результатом:{answer}");
            });

            
            Task.WaitAll(tasks);
            Console.WriteLine("Все задачи завершены");

            
            Task.WaitAny(tasks);
            Console.WriteLine("Хотя бы одна задача завершена");
        }
    }
    
}
