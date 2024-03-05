using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3
{
    internal class A
    {

        public int b { get; set; }
        public int a { get; set; }

        public A(int a, int b)
        {
           this.b = b;
           this.a = a;
        }

        public  double Kalculation(int a, int b)
        {
            double answer = ((3 * b) - (2 / Math.Pow(a, 2))) / 4;

            return answer;
        }

        public  double Cubing(int a, int b)
        {
            double answer = Math.Pow(a - b, 3);
            return answer;
        }
    }
}
