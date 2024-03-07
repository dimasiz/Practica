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
            try
            {
                double A, B, C, D;

                Console.Write("Введите значение A: ");
                A = double.Parse(Console.ReadLine());

                Console.Write("Введите значение B: ");
                B = double.Parse(Console.ReadLine());

                Console.Write("Введите значение C: ");
                C = double.Parse(Console.ReadLine());

                Console.Write("Введите значение D: ");
                D = double.Parse(Console.ReadLine());


               
               var item =  Minmax(A, B);
               var minNumber = item.Item1;
              

               if(minNumber > Minmax(C, D).Item1)
               {
                    minNumber = Minmax(C, D).Item1;
               }
               if(minNumber > Minmax(A, C).Item1)
               {
                    minNumber = Minmax(A, D).Item1;
               }
               if (minNumber > Minmax(B, D).Item1)
               {
                    minNumber = Minmax(B, D).Item1;
               }

                var maxNumber = item.Item2;
                if (maxNumber > Minmax(C, D).Item2)
                {
                    maxNumber = Minmax(C, D).Item2;
                }
                if (maxNumber > Minmax(A, C).Item2)
                {
                    maxNumber = Minmax(A, D).Item2;
                }
                if (maxNumber > Minmax(B, D).Item2)
                {
                    maxNumber = Minmax(B, D).Item2;
                }

                Console.WriteLine($"Минимальное значение: {minNumber}");
                Console.WriteLine($"Максимальное значение: {maxNumber}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка ввода");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("деления на ноль");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }


        static (double,double) Minmax(double X,  double Y)
        {
            if (X > Y)
            {
                double temp = X;
                X = Y;
                Y = temp;
            }

            return (X, Y);
        }

    }
}
