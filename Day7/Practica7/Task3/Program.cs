using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите Текст");

            string s = Console.ReadLine();

            string[] mas1 = s.Split(' ');

            string firstWord = mas1[0];
            string LastWord = mas1[mas1.Length -1];

            mas1[0] = LastWord;
            mas1[mas1.Length - 1] = firstWord;
            string firstTask = string.Join(" ",mas1); 
            Console.WriteLine($"Первое задание:{firstTask}");

            string[] mas2 = s.Split(' ');
            mas2[1] = mas1[1] + mas2[2];
            mas2[2] = "";
            string secondTask = string.Join(" ",mas2);
            Console.WriteLine($"Второе задание:{secondTask}");

            string[] mas3 = s.Split(' ');
            char[] word2 = mas3[2].ToCharArray(); 
            Array.Reverse(word2); 
            mas3[2] = string.Join("", word2);
            string thirdTask = string.Join(" ", mas3);
            Console.WriteLine($"Третие задание:{thirdTask}");


            string[] mas4 = s.Split(' ');
            char[] word1 = mas4[0].ToCharArray();
            word1[0] = ' ';
            word1[1] = ' ';
            mas4[0] = string.Join("", word1);
            string fourTask = string.Join(" ", mas4);
            Console.WriteLine($"четвертое задание:{fourTask}");
        }
    }
}
