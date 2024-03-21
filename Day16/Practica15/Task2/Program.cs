using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            MyDictionary<string, int> myDictionary = new MyDictionary<string, int>();
            myDictionary.Add("Звенит январская вьюга", 1);
            myDictionary.Add("И ливни хлещат друг друга", 2);
            myDictionary.Add("и звезды мчаться по кругу", 3);

            Console.WriteLine($"Значение элемента:{myDictionary["И ливни хлещат друг друга"]}");
            Console.WriteLine($"Количество:{myDictionary.Count}");

            Console.ReadLine();
        }
    }
}
