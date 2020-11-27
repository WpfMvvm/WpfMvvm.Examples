namespace WpfMvvm.Converters.Examples.Dictionaries
{
    public abstract class Figure
    {
        public double Width { get; set; }
        public double Height { get; set; }
    }

    public class Line : Figure { }
    public class Circle : Figure { }
    public class Rectangle : Figure { }
    public class Square : Rectangle { }
}
