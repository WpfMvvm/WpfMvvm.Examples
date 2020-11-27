using System.Windows;
using WpfMvvm.Converters;

namespace WpfMvvmApp
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void OnStartup(object sender, StartupEventArgs e)
        {
            //var converter = StaticMethodsOfConverters.GetDefaultValueConverter(typeof(string), typeof(Point), false);

            //var value = converter.Convert("12 34", null, null, null);
            //value = converter.Convert("12/34", null, null, null);

        }

    }
}
