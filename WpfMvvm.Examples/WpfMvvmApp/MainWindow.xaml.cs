using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfMvvmApp
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
    }

    [ContentProperty(nameof(Dictionary))]

    public partial class ViewModel 
    {
        public IDictionary Dictionary { get; set; } = new Dictionary<object, object>();
    }
    public partial class ViewModel : ISupportInitialize
    {
        /// <summary>Объект находится в состояни инициализации.</summary>
        public bool IsInit { get; private set; }
        public void BeginInit() => IsInit = true;

        public void EndInit()
        {
            IsInit = false;

        }
    }
    public partial class ViewModel : IDictionary
   {
        public object this[object key] { get => Dictionary[key]; set => Dictionary[key] = value; }

        public ICollection Keys => Dictionary.Keys;

        public ICollection Values => Dictionary.Values;

        public bool IsReadOnly => Dictionary.IsReadOnly;

        public bool IsFixedSize => Dictionary.IsFixedSize;

        public int Count => Dictionary.Count;

        public object SyncRoot => Dictionary.SyncRoot;

        public bool IsSynchronized => Dictionary.IsSynchronized;

        public void Add(object key, object value)
        {
            Dictionary.Add(key, value);
        }

        public void Clear()
        {
            Dictionary.Clear();
        }

        public bool Contains(object key)
        {
            return Dictionary.Contains(key);
        }

        public void CopyTo(Array array, int index)
        {
            Dictionary.CopyTo(array, index);
        }

        public IDictionaryEnumerator GetEnumerator()
        {
            return Dictionary.GetEnumerator();
        }

        public void Remove(object key)
        {
            Dictionary.Remove(key);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)Dictionary).GetEnumerator();
        }
    }
}
