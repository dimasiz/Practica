using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        ObservableCollection<FrameworkElement> controls = new ObservableCollection<FrameworkElement>();
        public MainWindow()
        {
            InitializeComponent();
            MainItemsControl.ItemsSource = controls;
        }

   
        private void CreateControlButton_Click(object sender, RoutedEventArgs e)
        {
            string type = TypeTextBox.Text;
            int x = int.Parse(XTextBox.Text);
            int y = int.Parse(YTextBox.Text);

            FrameworkElement control = null;

            switch (type)
            {
                case "К":
                    control = new Button()
                    {
                        Content = "Кнопка",
                        Width = 100,
                        Height = 50,
                    };
                    break;
                case "П":
                    control = new TextBox()
                    {
                        Width = 100,
                        Height = 20,
                    };
                    break;
                case "М":
                    control = new Label()
                    {
                        Content = "Метка",
                        Width = 100,
                        Height = 50,
                    };
                    break;
                default:
                    MessageBox.Show("Некорректный тип элемента управления.");
                    break;
            }

            if (control != null)
            {
                control.MouseEnter += Control_MouseEnter;
                controls.Add(control);
            }
        }

        private void Control_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            FrameworkElement control = (FrameworkElement)sender;
            controls.Remove(control);
        }
    }
}
