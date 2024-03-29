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

namespace Task1
{
  
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double y = int.Parse(TextBox2.Text);
            double x = int.Parse(TextBox1.Text);
            double z = int.Parse(TextBox3.Text);

            TextBox4.Text = Solution(x, y, z).ToString();

            
        }


        private double Solution(double x, double y, double z)
        {
            return Math.Pow(2, Math.Pow(x, y)) + Math.Pow(3, Math.Pow(x, y)) - y * (Math.Atan(z) - (Math.PI / 6)) / Math.Abs(x) + (1 / Math.Pow(y, 2) + 1); 
        }
    }
}
