using System.Collections.Generic;
using System.Windows.Media;

namespace WpfMvvm.Converters.Examples.Dictionaries
{
    public static class ValuesForView
    {
        public static Dictionary<object, object> Dictionary { get; } = new Dictionary<object, object>()
        {
            {1, "Один"},
            {2, "Два"},
            {3, "Три"},
            {4, "Четыре"},
            {5, "Пять"},
            { "Голубой", Brushes.LightBlue},
            { "Зелёный", Brushes.Green},
            { "Жёлтый", Brushes.Yellow},
        };
    }
}
