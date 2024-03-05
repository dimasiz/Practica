using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Cyrcle
    {
        public double Radius { get; set; }
        public double X { get; set; }
        public double Y { get; set; }

        public Cyrcle(double radius, double x, double y)
        {
            Radius = radius;
            X = x;
            Y = y;
        }
        public double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public double GetLengthCyrcle()
        {
            return 2 * Math.PI * Radius;
        }

        public bool IsPointInside(double pointX, double pointY)
        {
            double distance = Math.Sqrt(Math.Pow(pointX - X, 2) + Math.Pow(pointY - Y, 2));

            if(distance <= Radius) 
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }
    }
}
