using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
       
        static void Main(string[] args)
        {

            Console.Write("Введите число:");
            int number = int.Parse(Console.ReadLine()); 
            Task<int> task1 = Task.Run(() =>
            {
                
                int hundreds = (number / 100) % 10;
                int units = number % 10;

              
                int result = hundreds * units;

                return result;
            });

            
            Task task2 = task1.ContinueWith((prevTask) =>
            {
                int result = prevTask.Result;
                Console.WriteLine("Результат: " + result);
            });

            
            task2.Wait();
        }
    }
}
