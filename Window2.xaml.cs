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
    /// <summary>
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2
    {
        public Window2()
        {
            InitializeComponent();
            Lang();
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

        private void Lang()
        {
            // Подключение словаря
            A1.Content = Resource.A;
            B1.Content = Resource.B;
            C1.Content = Resource.C;
            D1.Content = Resource.D;
            E1.Content = Resource.E;
            F1.Content = Resource.F;
            G1.Content = Resource.G;
            H1.Content = Resource.H;
            I1.Content = Resource.I;
            J1.Content = Resource.J;

            A2.Content = Resource.A;
            B2.Content = Resource.B;
            C2.Content = Resource.C;
            D2.Content = Resource.D;
            E2.Content = Resource.E;
            F2.Content = Resource.F;
            G2.Content = Resource.G;
            H2.Content = Resource.H;
            I2.Content = Resource.I;
            J2.Content = Resource.J;
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

        private void But_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

