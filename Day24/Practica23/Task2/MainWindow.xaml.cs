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
using OxyPlot;
using OxyPlot.Series;

namespace Task2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public PlotModel PlotModel { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            PlotModel = new PlotModel { Title = "График функции" };
            DataContext = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double startX = double.Parse(TextBoxStartX.Text);
            double endX = double.Parse(TextBoxEndX.Text);
            double stepSize = double.Parse(TextBoxStepSize.Text);

            PlotModel.Series.Clear();

            LineSeries series = new LineSeries();
            for (double x = startX; x <= endX; x += stepSize)
            {
                double y = -x;
                series.Points.Add(new DataPoint(x, y));
            }

            PlotModel.Series.Add(series);
            PlotModel.InvalidatePlot(true);
        }
    }
}
