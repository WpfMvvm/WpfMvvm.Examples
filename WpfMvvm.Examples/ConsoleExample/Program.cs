using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfMvvm.Converters;

namespace ConsoleExample
{
    class Program
    {
        static void Main(string[] args)
        {
            BooleanNotConverter booleanNot = new BooleanNotConverter();
            Debug.WriteLine("Hello World!");

            var obj = new object();
        }
    }
}
