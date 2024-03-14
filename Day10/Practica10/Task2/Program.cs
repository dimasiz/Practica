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

            Console.WriteLine("Ввдите колличесвто Строк 1 матрицы:");
            int line = int.Parse(Console.ReadLine());
            Console.WriteLine("Ввдите колличесвто Столбцев 1 матрицы:");
            int column = int.Parse(Console.ReadLine());

            Console.WriteLine("Ввдите колличесвто Строк 2 матрицы:");
            int line1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ввдите колличесвто Столбцев 2 матрицы:");
            int column1 = int.Parse(Console.ReadLine());


            FloatMatrix floatMatrix = new FloatMatrix(line, column);
            FloatMatrix floatMatrix1 = new FloatMatrix(line, column);

            bool flag = true;
            string type = "";

            while (flag)
            {
                Console.WriteLine("1 - Создать  матрицы\n2 - посмотреть матрицы\n3 - проверить параметры матриц\n4 - сравнить матрицы\n5 - нахождение элемента по индексу\n0 - выход");
                Console.WriteLine("Введите команду ");
                byte command = byte.Parse(Console.ReadLine());

                switch (command)
                {
                    case 0:
                        flag = false;
                        break;

                    case 1:
                        floatMatrix.CreateMatrix();
                        floatMatrix1.CreateMatrix();
                        break;

                    case 2:
                        Console.WriteLine("первая матрица:");
                        floatMatrix.WriteMatrix();
                        Console.WriteLine("вторая матрица:");
                        floatMatrix1.WriteMatrix();
                        break;

                    case 3:
                        Console.WriteLine("первая матрица:");
                        Console.WriteLine(floatMatrix.TypeCheckMatrix());
                        Console.WriteLine("вторая матрица:");
                        Console.WriteLine(floatMatrix1.TypeCheckMatrix());
                        break;

                    case 4:
                        Console.WriteLine(floatMatrix.СomparisonMatrix(floatMatrix, floatMatrix1));
                        break;

                    case 5:
                        Console.WriteLine("Выберите номер матрицы (1 или 2)");
                        byte count = byte.Parse(Console.ReadLine());

                        Console.WriteLine("Введиет индексы");
                        int top = int.Parse(Console.ReadLine());
                        int bot = int.Parse(Console.ReadLine());

                        if (count == 1)
                        {
                            double num = floatMatrix.FindElement(top, bot);
                            Console.WriteLine(num);
                        }
                        else if (count == 2)
                        {
                            double num = floatMatrix1.FindElement(top, bot);
                            Console.WriteLine(num);
                        }
                        else
                        {
                            Console.WriteLine("вы ввели номер несуществующей матрицы");
                        }
                        break;

                }
            }
        }
    }
}
