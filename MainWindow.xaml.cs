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
            var uri = new Uri("Light.xaml", UriKind.Relative);
            System.Windows.ResourceDictionary resourceDict = Application.LoadComponent(uri) as System.Windows.ResourceDictionary;
            Application.Current.Resources.MergedDictionaries.Add(resourceDict);
        }
        private void ThemeChange(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            string style = b.Name;
            //string style = Button.Name;
            // определяем путь к файлу ресурсов
            var uri = new Uri(style + ".xaml", UriKind.Relative);
            // загружаем словарь ресурсов
            System.Windows.ResourceDictionary resourceDict = Application.LoadComponent(uri) as System.Windows.ResourceDictionary;
            // очищаем коллекцию ресурсов приложения
            Application.Current.Resources.Clear();
            // добавляем загруженный словарь ресурсов
            Application.Current.Resources.MergedDictionaries.Add(resourceDict);
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
            // Подключение словаря
            Name.Content = Resource.Name;
            Play.Content = Resource.Play;
            Settings.Content = Resource.Settings;
            Exit.Content = Resource.Exit;
        }

        private void Play_Click(object sender, RoutedEventArgs e)
        {
            Window1 newForm = new Window1();
            newForm.Show();
            this.Close();
        }
    }
}
