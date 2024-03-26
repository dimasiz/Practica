using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    /// <summary>
    /// Класс, содержащий программу.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            RealMatrix matrix = new RealMatrix(3, 3);

            matrix[0, 0] = 1.5;
            matrix[0, 1] = 0;
            matrix[0, 2] = -2.3;
            matrix[1, 0] = 0;
            matrix[1, 1] = 4.2;
            matrix[1, 2] = 0;
            matrix[2, 0] = -3;
            matrix[2, 1] = 0;
            matrix[2, 2] = 2.7;

            Console.WriteLine("Исходная матрица:");
            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Columns; j++)
                {
                    Console.Write($"{matrix[i, j]}  ");
                }
                Console.WriteLine();
            }

            matrix.ChangeValues();

            Console.WriteLine("Измененная матрица:");
            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Columns; j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
