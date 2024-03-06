using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class RealMatrix
    {
        private int rows; 
        private int columns; 
        private double[,] data; 


        public int Rows { get; set; }
       
        public int Columns { get;set;  }

      

        public RealMatrix(int rows, int columns)
        {
           Rows = rows;
           Columns = columns;
           data = new double[rows, columns];
        }

        
        public double this[int row, int column]
        {
            get { return data[row, column]; }
            set { data[row, column] = value; }
        }

     
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
