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
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
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
            Next.Content = Resource.Next;
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

        private void Play_Click(object sender, RoutedEventArgs e)
        {
            Window2 newForm = new Window2();
            newForm.Show();
            this.Close();
        }

        private void But_Click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            if (b.Background == Brushes.Orange)
            {
                if (Light.Background.ToString() == "#FFE5E5E5")
                {
                    b.Background = (Brush)new BrushConverter().ConvertFrom("#FFE5E5E5");
                }
                else
                {
                    b.Background = (Brush)new BrushConverter().ConvertFrom("#1c1c1c");
                }
            }
            else
            {
                b.Background = Brushes.Orange;
            }
        }
    }
}
