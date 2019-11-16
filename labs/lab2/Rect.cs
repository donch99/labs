using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class Rect : Rectangle
    {
        public Rect(double length) : base(length, length) { }
        public override string ToString()
        {
            return $"Тип: Квадрат, Сторона: {width}, Площадь: {Area()}";
        }
    }
}
