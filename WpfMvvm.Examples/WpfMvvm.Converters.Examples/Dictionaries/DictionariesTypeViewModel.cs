﻿using System;
using System.Collections.Generic;

namespace WpfMvvm.Converters.Examples.Dictionaries
{
    public class DictionariesTypeViewModel
    {
        public Figure[] Figures { get; }
        =   {
                new Circle() {Width = 100, Height = 100},
                new Line() {Width = 100, Height = 100},
                new Rectangle() {Width = 100, Height = 100},
                new Circle() {Width = 50, Height = 100},
                new Square() {Width = 50, Height = 100},
                new Line() {Width = 50, Height = 100}
            };

        public Dictionary<Type, string> TypesFigures { get; }
            = new Dictionary<Type, string>()
            {
                { typeof(Figure), "Фигура" },
                { typeof(Circle), "Элипс" },
                { typeof(Rectangle), "Прямоугольник" },
                { typeof(Square), "Квадрат" }
            };
    }
}
