using System;
using System.Collections.Generic;
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

namespace Task3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private const double a = 0.1;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double b = int.Parse(TextBox2.Text);
            double x = int.Parse(TextBox1.Text);

            TextBox4.Text = FindY(x, b).ToString();


        }


        private double FindY(double x, double b)
        {
            return  x + Math.Sqrt(Math.Abs(Math.Pow(x,3) + a)- b * Math.Pow(Math.E, x)) ;
        }

       
    }
}
