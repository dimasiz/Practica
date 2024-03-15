using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class A
    {
        protected int a;
        protected int b;

        public A(int a, int b)
        {
            AValue = a;
            BValue = b;
        }

        public int AValue { get; set; }
        public int BValue { get; set; }
    }
}
