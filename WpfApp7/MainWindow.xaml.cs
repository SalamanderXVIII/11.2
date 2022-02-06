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

namespace WpfApp7
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DateTime date1;
        Date date = new Date();
        public MainWindow()
        {
            InitializeComponent();
        }

        public void Accept_Click(object sender, RoutedEventArgs e)
        {
            date1 = new DateTime(date.year, date.month, date.day);
            Output.Text = date1.ToString("d");
        }

        private void TextDays_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (TextDay.Text != "")
            date.day = Convert.ToInt32(TextDay.Text);
        }

        private void TextMonth_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (TextMonth.Text != "")
            date.month = Convert.ToInt32(TextMonth.Text);
        }

        private void TextYears_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (TextYear.Text != "")
            date.year = Convert.ToInt32(TextYear.Text);
        }

        private void Year1_Click(object sender, RoutedEventArgs e)
        {
            if (Output.Text != "0")
            {
                date1 = date1.AddYears(1);
                Output.Text = date1.ToString("d");
            }
        }

        private void Days2_Click(object sender, RoutedEventArgs e)
        {
            if (Output.Text != "0")
            {
                date1 = date1.AddDays(-2);
                Output.Text = date1.ToString("d");
            }
        }
    }
}
