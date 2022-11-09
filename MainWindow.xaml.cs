using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace Морской_бой
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Lang();
        }
        private void Lang_Ru_Click(object sender, RoutedEventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("ru");
            Lang();
        }
        private void Lang_En_Click(object sender, RoutedEventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en");
            Lang();
        }

        private void Lang()
        {
            // Подключение словаря к словам.
            Name.Content = Resource.Name;
            Play.Content = Resource.Play;
            Settings.Content = Resource.Settings;
            Exit.Content = Resource.Exit;
        }
    }
}
