using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Rectangle : Square
    {
        private double sideDifference;

        public Rectangle(string name, double side, double sideDifference) : base(name, side)
        {
            this.sideDifference = sideDifference;
        }

        public double SideDifference
        {
            get { return sideDifference; }
            set { sideDifference = value; }
        }

        public double CalculateArea()
        {
            return Side * sideDifference;
        }

        public new void DisplayFields()
        {
            base.DisplayFields();
            Console.WriteLine($"Вторая сторона: {sideDifference}");
        }

        

    }
}
