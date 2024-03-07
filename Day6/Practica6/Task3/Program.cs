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
            
            Console.Write("Введите размерность: ");
            int N = int.Parse(Console.ReadLine());
            
            int[,] matrix = new int[N, N];
            Random random = new Random();

            Console.WriteLine("Матрица:");

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    matrix[i, j] = random.Next(1, 100);
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }

        
            Console.Write("Введите значение K: ");
            int K = int.Parse(Console.ReadLine());

            Console.Write("Введите значение L: ");
            int L = int.Parse(Console.ReadLine());

            
            int sum = 0;

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (matrix[i, j] >= K && matrix[i, j] < L)
                    {
                        sum += matrix[i, j];
                    }
                }
            }

            Console.WriteLine("Сумма чисел в промежутке [{0}, {1}): {2}", K, L, sum);

          
            Console.Write("Введите значение k: ");
            int k = int.Parse(Console.ReadLine());

          
            int maxElement = matrix[0, k - 1];

            for (int i = 1; i < N; i++)
            {
                if (matrix[i, k - 1] > maxElement)
                {
                    maxElement = matrix[i, k - 1];
                }
            }

            Console.WriteLine("Наибольший элемент в {0}-м столбце: {1}", k, maxElement);
        }
    }
    
}
