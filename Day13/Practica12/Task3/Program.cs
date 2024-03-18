using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Program
    {
        public delegate void StringAction(string text);
        static void Main(string[] args)
        {
            StringAction stringAction;

            stringAction = ReverseString;
            stringAction += UppercaseString;
            stringAction += LowercaseString;

            stringAction("Hello, world!");
        }

        public static void ReverseString(string text)
        {
            char[] charArray = text.ToCharArray();
            Array.Reverse(charArray);
            string reversedText = new string(charArray);
            Console.WriteLine("Обратная строка: " + reversedText);
        }

        public static void UppercaseString(string text)
        {
            string uppercaseText = text.ToUpper();
            Console.WriteLine("Строка в верхнем регистре:" + uppercaseText);
        }

        public static void LowercaseString(string text)
        {
            string lowercaseText = text.ToLower();
            Console.WriteLine("Строка в нижнем регистре:" + lowercaseText);
        }
    }
}
