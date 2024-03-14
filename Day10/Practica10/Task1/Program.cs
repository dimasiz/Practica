using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestClass obj = new TestClass();
            obj.w = 10;

            
            Iy iy = obj;
            Iz iz = obj;

            iy.F0(20); 
            iy.F1();  

            iz.F0(30);
            iz.F1();   


            ((Ix)obj).IxF0(40);  
            ((Ix)obj).IxF1();    

            
            Ix ix = obj;
            ix.IxF0(50);  
            ix.IxF1();    
        }
    }
}
