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
            Console.WriteLine("Введите четырехзначное число:");
            int number = int.Parse(Console.ReadLine());

            int firstDigit = number / 1000;      
            int secondDigit = (number / 100) % 10; 
            int thirdDigit = (number / 10) % 10;  
            int fourthDigit = number % 10;        

            int newNumber = secondDigit * 1000 + firstDigit * 100 + fourthDigit * 10 + thirdDigit;

            Console.WriteLine("Перестановка цифр: " + newNumber);
            Console.ReadLine();
        }
    }
}
