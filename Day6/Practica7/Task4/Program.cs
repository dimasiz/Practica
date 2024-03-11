using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string secondName = "Шведко";
            string firstName = "Дмитрий";
            string lastName = "Иванович";
            string fullName = secondName + firstName + lastName;

            fullName = fullName.ToUpper();

            int kod = KalculateKod(fullName);

            Console.WriteLine("Код личности: " + kod);
            Console.ReadKey();
        }

        static int KalculateKod(string name)
        {
            int summa = 0;

            char[] alphabet = new char[] { 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ъ', 'Ы', 'Ь', 'Э', 'Ю', 'Я' };
            char[] fulllname = name.ToCharArray();
            foreach (char symbol in fulllname)
            {
                for (int i = 0; i < alphabet.Length; i++)
                {
                    if (symbol == alphabet[i])
                    {
                        summa += i + 1;
                    }
                }
            }

            string numbers;

            while (summa >= 10)
            {
                numbers = summa.ToString();
                summa = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    string number = numbers[i].ToString();
                    int numb = int.Parse(number);
                    summa += numb;
                }
            }

            return summa;
        }
    }
}
