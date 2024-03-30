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
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string inputText = TextBoxInput.Text;
            string outputText = SwapFirstAndLastLetters(inputText);
            TextBoxOutput.Text = outputText;
        }

        private string SwapFirstAndLastLetters(string input)
        {
            string[] words = input.Split(' ');
            string[] swappedWords = words.Select(SwapFirstAndLastLetter).ToArray();
            return string.Join(" ", swappedWords);
        }

        private string SwapFirstAndLastLetter(string word)
        {
            if (word.Length <= 1)
                return word;

            char firstLetter = word[0];
            char lastLetter = word[word.Length - 1];
            string middlePart = word.Substring(1, word.Length - 2);
            return lastLetter + middlePart + firstLetter;
        }
    }
}
