using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Task4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string[] months = new string[]
          {
            "Январь",
            "Февраль",
            "Март",
            "Апрель",
            "Май",
            "Июнь",
            "Июль",
            "Август",
            "Сентябрь",
            "Октябрь",
            "Ноябрь",
            "Декабрь"
          };

        public string[] regions = new string[]
         {
            "Брестская область",
            "Витебская область",
            "Гомельская область",
            "Гродненская область",
            "Минская область",
            "Могилевская область"
         };
        public MainWindow()
        {
            InitializeComponent();

            for (int i = 1; i <= 31; i++)
            {
                Day.Items.Add(i);
            }

            for (int i = 1950; i <= 2024; i++)
            {
                Year.Items.Add(i);
            }

            for (int i = 0; i <= 11; i++)
            {
                Mouth.Items.Add(months[i]);
            }

            for (int i = 0; i <= 5; i++)
            {
                City.Items.Add(regions[i]);
            }

        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            Day.SelectedItem = string.Empty;
            Year.SelectedItem = string.Empty;
            Mouth.SelectedItem = string.Empty;
            FirstName.Text = string.Empty;
            SecondName.Text = string.Empty;
            LastName.Text = string.Empty;
            City.SelectedItem = string.Empty;
            TextShort.Text = string.Empty;

        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            string fileName = "File.txt";

            string firstName = FirstName.Text;
            string lastName = LastName.Text;
            string middleName = SecondName.Text;
            string month = Mouth.Text;
            string year = Year.Text;
            string day = Day.Text;
            string phoneNumber = Number1.Text;
            string address = City.SelectedItem.ToString();
            string Resume = TextShort.Text;



            using (StreamWriter writer = File.AppendText(fileName))
            {
                writer.WriteLine("Имя: " + firstName);
                writer.WriteLine("Фамилия: " + lastName);
                writer.WriteLine("Отчество: " + middleName);
                writer.WriteLine("Месяц: " + month);
                writer.WriteLine("Год: " + year);
                writer.WriteLine("День: " + day);
                writer.WriteLine("Номер Телефона: " + phoneNumber);
                writer.WriteLine("Адрес: " + address);
                writer.WriteLine("Резюме");
                writer.WriteLine();
            }

        }
    }
}
