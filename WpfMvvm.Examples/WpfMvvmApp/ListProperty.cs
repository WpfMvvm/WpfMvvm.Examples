using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace WpfMvvmApp
{
    [DefaultProperty(nameof(List))]
    [ContentProperty(nameof(List))]
    public class ListProperty
    {
        public List<object> List { get; } = new List<object>();
    }
}
