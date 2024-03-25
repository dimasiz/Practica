using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;

            Queue<int> inRangeQueue = new Queue<int>();
            Queue<int> lessThanAQueue = new Queue<int>();
            Queue<int> greaterThanBQueue = new Queue<int>();


            using (StreamReader sr = new StreamReader("input.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    int number = int.Parse(line);

                    if (number >= a && number <= b)
                        inRangeQueue.Enqueue(number);
                    else if (number < a)
                        lessThanAQueue.Enqueue(number);
                    else
                        greaterThanBQueue.Enqueue(number);
                }
            }


            while (inRangeQueue.Count > 0)
            {
                Console.WriteLine(inRangeQueue.Dequeue());
            }

            while (lessThanAQueue.Count > 0)
            {
                Console.WriteLine(lessThanAQueue.Dequeue());
            }

            while (greaterThanBQueue.Count > 0)
            {
                Console.WriteLine(greaterThanBQueue.Dequeue());
            }

            Console.ReadKey();
        }
    }
}
