using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

using WpfApp1.models;
using Microsoft.Extensions.Logging;
using WpfApp1.Share;



namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly XmlDocumentWorker _worker;
        private readonly ILogger _logger;
        public bool IsFileOpenned = false;
        private string _xmlFilePath;
        public MainWindow()
        {
            InitializeComponent();

            _logger = LoggerFactory.Create(builder => builder
            .SetMinimumLevel(LogLevel.Information))
                .CreateLogger<MainWindow>();
            _worker = new XmlDocumentWorker(_logger);
        }

  

      public void PrintCountry(Country country)
      {
            textBlockXMlFileContent.Text = "===Counry====" + Environment.NewLine;
            textBlockXMlFileContent.Text += country?.ToString() ?? "CountryNotFound";
      }

        private void textBoxDeleteCountryName_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxCountryName.Text))
            {
                PrintContries(_worker.GetAll());
            }
        }

        private void PrintContries(List<Country> countries)
        {
            textBlockXMlFileContent.Text = "===Counry====" + Environment.NewLine;
            foreach(var country in countries)
            {
                textBlockXMlFileContent.Text += country.ToString();
            }
        }

        private void buttonOpenFile_Click_1(object sender, object e)
        {
            var dialog = new OpenFileDialog();

            dialog.InitialDirectory = Directory.GetParent(AppContext.BaseDirectory)
                .Parent
                .Parent
                .FullName;

            dialog.DefaultExt = ".xml";
            dialog.Filter = "Xml documents (.xml)|*.xml";
            var result = dialog.ShowDialog();
            if (result.HasValue && result.Value)
            {
                _xmlFilePath = dialog.FileName;
                textBlockXMLPathFile.Text = _xmlFilePath;
                _worker.Load(_xmlFilePath);
                PrintContries(_worker.GetAll());
            }
        }

        private void buttonFindCountryName_Click_1(object sender, RoutedEventArgs e)
        {

            var counry = _worker.FindBy(textBoxCountryName.Text);
            PrintCountry(counry);
        }

        private void buttonAdd_Click_1(object sender, object e)
        {
            PrintContries(_worker.GetAll());
        }

        private void buttonExit_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void buttonDelete_Click_1(object sender, object e)
        {
            if (!string.IsNullOrEmpty(textBoxDeleteCountryName.Text) || !string.IsNullOrWhiteSpace(textBoxDeleteCountryName.Text))
            {
                _worker.Delete(textBoxDeleteCountryName.Text);
                PrintContries(_worker.GetAll());
            }
        }

      
    }
    }


