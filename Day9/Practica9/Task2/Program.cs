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
            Console.InputEncoding = Encoding.GetEncoding("utf-16");
            Console.OutputEncoding = Encoding.GetEncoding("utf-16");

            Accauntant accauntant = new Accauntant();

            int employeeHours = 190;
            bool bonus = accauntant.AskForBonus(Accauntant.Post.Manager, employeeHours);
            if (bonus)
            {
                Console.WriteLine("Сотруднику положена премия");
            }
            else
            {
                Console.WriteLine("Сотруднику премия не положена");
            }

            bool bonus1 = accauntant.AskForBonus(Accauntant.Post.Junior, employeeHours);
            if (bonus1)
            {
                Console.WriteLine("Сотруднику положена премия");
            }
            else
            {
                Console.WriteLine("Сотруднику премия не положена");
            }
            Console.ReadLine();
        }
    }
}
