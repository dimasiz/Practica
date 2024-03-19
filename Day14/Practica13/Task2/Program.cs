using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Task_2.MyInfo;

namespace Task_2
{

    class Program
    {
        public static void Main(string[] args)
        {
            MyInfo info = new MyInfo("Ренат");
            info.NameChanged += Info_NameChanged;
            info.Name = "Дима";
            info.Name = "Антон";
            Console.ReadKey();
        }

        private static void Info_NameChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Имя было изменено");
        }
    }
}
