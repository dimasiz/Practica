using System;
using System.Collections;
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
            Console.Write("Введите текст:");
            string text = Console.ReadLine();
            char[] chars = text.ToCharArray();

            Stack<char> stack = new Stack<char>();

            foreach (char c in text)
            {
                if (c != '#')
                {
                    stack.Push(c);
                }
                else if (stack.Count > 0)
                {
                    stack.Pop();
                }
            }

           char[] newCharText = stack.ToArray();
           newCharText = newCharText.Reverse().ToArray();
           string newText = new String(newCharText);
           Console.WriteLine(newText);
        }
    }
}
