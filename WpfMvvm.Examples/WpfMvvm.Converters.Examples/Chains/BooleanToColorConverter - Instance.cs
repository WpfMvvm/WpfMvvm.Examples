using System.Windows.Data;

namespace WpfMvvm.Converters.Examples.Chains
{
    public partial class BooleanToColorConverter
    {
        /// <summary>Экземпляр конвертера.</summary>
        public static BooleanToColorConverter Instance { get; } = new BooleanToColorConverter();

        /// <summary>Экземпляр конвертера с отрицанием.</summary>
        public static IValueConverter InstanceNot { get; }
            = new ReadOnlyChainOfConverters(BooleanNotConverter.Instance, Instance);

    }
}
