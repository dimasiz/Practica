using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Program
    {
        public static void ColorHandler(object sender, ColorEvent e)
        {
            Console.WriteLine("Получен цвет: " + e.Color);
        }

        public delegate string ColorDelegate();

        static void Main(string[] args)
        {
            ColorProvider colorProvider = new ColorProvider();
            colorProvider.ColorGenerated += ColorHandler;

            ExecuteColorDelegate(colorProvider.GetColors);

            Console.ReadLine();
        }

        public static void ExecuteColorDelegate(ColorDelegate colorDelegate)
        {
            try
            {
                string colors = colorDelegate.Invoke();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка:" + ex.Message);
            }
        }
    }
}
