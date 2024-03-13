using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.GetEncoding("utf-16");
            Console.OutputEncoding = Encoding.GetEncoding("utf-16");

            bool flag = true;
            byte command;

            List<Marsh> marshes = new List<Marsh>();

            while (flag)
            {
                Console.WriteLine("1 - создать маршруты\n2 - Просмотреть все маршруты\n3 - Найти опредлный маршрут");
                Console.WriteLine("Ввод команды:");
                command = byte.Parse(Console.ReadLine());
                switch (command)
                {
                    case 0:
                        flag = false;
                        break;

                    case 1:
                        marshes.Clear();
                        marshes = AddMarshes();
                        break;

                    case 2:
                        if (marshes.Count == 0)
                        {
                            Console.WriteLine("Список пуст");
                        }
                        else
                        {
                            Console.WriteLine("Список");
                            InformationAboutAllMarsh(marshes);
                        }
                        break;

                    case 3:
                        if (marshes.Count == 0)
                        {
                            Console.WriteLine("Список пуст");
                        }
                        else
                        {
                            Console.WriteLine("Введите Название Маршрута");
                            string name = Console.ReadLine();
                            FindMarsh(marshes, name);
                        }
                        break;

                    default:
                        Console.WriteLine("неверная команда");
                        break;
                }
            }



            Console.ReadKey();

        }

        static public void InformationAboutAllMarsh(List<Marsh> marshes)
        {

            for (int i = 0; i < marshes.Count; i++)
            {
                Console.WriteLine(marshes[i].WatchMarsh());
            }
        }

        static public List<Marsh> AddMarshes()
        {
            List<Marsh> listMarsh = new List<Marsh>();
            for (int i = 0; i < 8; i++)
            {

                int marsNumber = i + 1;
                Console.WriteLine("Введите начало маршрута");
                string marshBegin = Console.ReadLine();
                Console.WriteLine("Введите конец маршрута");
                string marshEnd = Console.ReadLine();

                Marsh marsh = new Marsh(marsNumber, marshBegin, marshEnd);
                listMarsh.Add(marsh);
            }
            return listMarsh;
        }

        static public void FindMarsh(List<Marsh> marshes, string name)
        {
            int count = 0;
            for (int i = 0; i < marshes.Count; i++)
            {
                if (name == marshes[i].MarshEnd || name == marshes[i].MarshBegin)
                {

                    Console.WriteLine(marshes[i].WatchMarsh());
                    count++;
                }

            }
            if (count == 0)
            {
                Console.WriteLine("Совпадение Отсутствуют");
            }
            count = 0;
        }
    }
}
