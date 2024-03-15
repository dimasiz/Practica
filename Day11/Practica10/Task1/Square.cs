using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Square
    {
        private string name;
        private double side;

        public Square(string name, double side)
        {
            this.name = name;
            this.side = side;
        }

        public double Side
        {
            get { return side; }
            set { side = value; }
        }

        public double CalculateArea()
        {
            return side * side;
        }

        public void DisplayFields()
        {
            Console.WriteLine($"Имя: {name}");
            Console.WriteLine($"Сторона: {side}");
        }


    }
}
