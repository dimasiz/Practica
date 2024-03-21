using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Program
    {
        static void Main(string[] args)
        {
            MyList<int> myList = new MyList<int>();
            myList.Add(10);
            myList.Add(20);
            myList.Add(30);

            Console.WriteLine("Элемент по индексу 1: " + myList[1]);
            Console.WriteLine("Количество элементов: " + myList.Count);

            Console.ReadLine();
        }
    }
}
