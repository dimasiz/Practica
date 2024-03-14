using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class FloatMatrix
    {
        public FloatMatrix(int line, int column)
        {
            this.Line = line;
            this.Column = column;
            this.Matrix = new double[line, column];

        }

        public int Line { get; set; }
        public int Column { get; set; }
        public double[,] Matrix { get; set; }



        public void WriteMatrix()
        {
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    Console.Write("{0:f4}  ", Matrix[i, j]);
                }
                Console.WriteLine();
            }

        }
        public double[,] CreateMatrix()

        {
            Random rand = new Random();
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    Matrix[i, j] = rand.Next(1, 20);
                }
            }
            return Matrix;
        }

        public double FindElement(int iElement, int jElement)
        {



            double element = 0;
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    if (iElement == i + 1 && jElement == j + 1)
                    {
                        element = Matrix[i, j];
                        return element;
                    }
                    else
                    {
                        element = 0;
                    }
                }
            }
            return element;
        }


        private string CheckTypeSqr()
        {

            if (Matrix.GetLength(0) == Matrix.GetLength(1))
            {
                return "квадратная";
            }
            else
            {
                return " ";
            }

        }

        private string CheckTypeDiagonal()
        {
            int counterZeroElement = 0;
            int counerItem = 0;
            for (int i = 1; i < Matrix.GetLength(0); i++)
            {
                for (int j = 1; j < Matrix.GetLength(1); j++)
                {
                    if (i != j && Matrix[i, j] == 0)
                    {
                        counterZeroElement++;
                    }

                    if (i == j && Matrix[i, j] != 0)
                    {
                        counerItem++;
                    }
                }
            }

            if (counerItem == Matrix.GetLength(0) && counterZeroElement == Matrix.Length)
            {
                return " Диагональная";
            }
            else
            {
                return "";
            }
        }

        private string CheckTypeMatrixZero()
        {

            int counterZero = 0;

            for (int i = 1; i < Matrix.GetLength(0); i++)
            {
                for (int j = 1; j < Matrix.GetLength(1); j++)
                {
                    if (Matrix[i, j] == 0)
                    {
                        counterZero++;
                    }
                }
            }
            if (counterZero == Matrix.Length)
            {
                return " нулевая";
            }
            else
            {
                return "";
            }
        }

        private string CheckTypeMatrixOne()
        {
            int counterOne = 0;

            for (int i = 1; i < Matrix.GetLength(0); i++)
            {
                for (int j = 1; j < Matrix.GetLength(1); j++)
                {
                    if (Matrix[i, j] == 1)
                    {
                        counterOne++;
                    }
                }
            }
            if (counterOne == Matrix.Length)
            {
                return " еденичная";
            }
            else
            {
                return "";
            }
        }

        private string CheckMatrixOnSemetriz()
        {
            bool symm = true;
            for (int i = 0; i < Matrix.GetLength(0); ++i)
            {
                for (int j = 0; j < Matrix.GetLength(1); ++j)
                    if (Matrix[i, j] != Matrix[j, i])
                    {
                        symm = false;
                        break;
                    }
                if (!symm) break;
            }
            if (symm == true)
            {
                return " семетричная";
            }
            else
            {
                return "";
            }
        }

        private string CheckMatixOnTriangle()
        {
            bool v = false; bool h = false;
            if (Matrix.GetLength(0) == Matrix.GetLength(1))
            {

                for (int i = 0; i < Matrix.GetLength(0) - 1; i++)
                {
                    for (int j = 0; j < Matrix.GetLength(1); j++)
                    {
                        if (Matrix[i, j] != 0)
                        {
                            v = false;
                        }
                        if (Matrix[j, i] != 0)
                        {
                            h = false;
                        }
                    }

                }
            }

            if (v == true)
                return " верхнетреугольная";
            if (h == true)
                return " нижннетреугольная";
            else
            {
                return "";
            }
        }

        public string TypeCheckMatrix()
        {
            string infoOfMatrix = "";

            infoOfMatrix += CheckTypeSqr() + CheckTypeDiagonal() + CheckTypeMatrixOne() + CheckTypeMatrixZero() + CheckMatrixOnSemetriz() + CheckMatixOnTriangle();
            return infoOfMatrix;
        }

        public string СomparisonMatrix(FloatMatrix matrix1, FloatMatrix matrix2)
        {
            int counter = 0;
            if (matrix1.Matrix.GetLength(0) == matrix2.Matrix.GetLength(0) && matrix1.Matrix.GetLength(1) == matrix2.Matrix.GetLength(1))
            {
                for (int i = 1; i < matrix1.Matrix.GetLength(0); i++)
                {
                    for (int j = 1; j < matrix1.Matrix.GetLength(1); j++)
                    {
                        if (matrix1.Matrix[i, j] == matrix2.Matrix[i, j])
                        {
                            counter++;
                        }
                    }
                }

                if (counter == matrix1.Matrix.Length)
                {
                    return "матрицы равны";
                }
                else
                {
                    return "матрицы не равны";
                }
            }
            else
            {
                return "матрицы невозможно сравнить";
            }
        }
    }
}
