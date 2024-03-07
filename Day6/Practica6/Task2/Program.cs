using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sequence = new int[100];
            Random random = new Random();

          
            for (int i = 0; i < sequence.Length; i++)
            {
                sequence[i] = random.Next(1, 100);
            }

            
            int minIndex = 0;
            int maxIndex = 0;

            for (int i = 1; i < sequence.Length; i++)
            {
                if (sequence[i] < sequence[minIndex])
                {
                    minIndex = i;
                }

                if (sequence[i] > sequence[maxIndex])
                {
                    maxIndex = i;
                }
            }

           
            int sum = 0;
            int startIndex = Math.Min(minIndex, maxIndex);
            int endIndex = Math.Max(minIndex, maxIndex);

            for (int i = startIndex; i <= endIndex; i++)
            {
                sum += sequence[i];
            }

         
            int count = endIndex - startIndex + 1;
            double average = (double)sum / count;

         
            Console.WriteLine("Минимальное число: " + sequence[minIndex]);
            Console.WriteLine("Максимальное число: " + sequence[maxIndex]);
            Console.WriteLine("Среднее арифметическое: " + average);


            Array.Sort(sequence);
            for(int i = 0; i < sequence.Length; i++)
            {
                Console.WriteLine($"Номер:{i} Значение:{sequence[i]}");
            }

            Console.Write("Введите число k: ");
            int k = int.Parse(Console.ReadLine());

            
            int index = BinarySearch(sequence, k);

            
            if (index != -1)
            {
                Console.WriteLine("Число k найдено на позиции " + index);
            }
            else
            {
                Console.WriteLine("Число k не найдено в массиве");
            }
        }

       public static int BinarySearch(int[] array, int target)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int middle = (left + right) / 2;

                if (array[middle] == target)
                {
                    return middle;
                }
                else if (array[middle] < target)
                {
                    left = middle + 1;
                }
                else
                {
                    right = middle - 1;
                }
            }

            return -1; 
        }
    }
}
