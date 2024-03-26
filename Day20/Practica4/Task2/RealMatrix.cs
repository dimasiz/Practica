using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    /// <summary>
    /// Класс, представляющий матрицу вещественных чисел.
    /// </summary>
    public class RealMatrix
    {
        private double[,] data;

        /// <summary>
        /// Количество строк матрицы.
        /// </summary>
        public int Rows { get; set; }

        /// <summary>
        /// Количество столбцов матрицы.
        /// </summary>
        public int Columns { get; set; }

        /// <summary>
        /// Индексатор для доступа к элементам матрицы.
        /// </summary>
        /// <param name="row">Номер строки.</param>
        /// <param name="column">Номер столбца.</param>
        /// <returns>Значение элемента матрицы.</returns>
        public double this[int row, int column]
        {
            get { return data[row, column]; }
            set { data[row, column] = value; }
        }

        /// <summary>
        /// Конструктор класса RealMatrix.
        /// </summary>
        /// <param name="rows">Количество строк.</param>
        /// <param name="columns">Количество столбцов.</param>
        public RealMatrix(int rows, int columns)
        {
            Rows = rows;
            Columns = columns;
            data = new double[rows, columns];
        }

        /// <summary>
        /// Метод для изменения значений в матрице.
        /// </summary>
        public void ChangeValues()
        {
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    if (data[i, j] != 0)
                    {
                        data[i, j] = -data[i, j];
                    }
                    else
                    {
                        data[i, j] = 1;
                    }
                }
            }
        }
    }
}
