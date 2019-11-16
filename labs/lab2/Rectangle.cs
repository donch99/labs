using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class Rectangle : geom_fig, IPrint
    {
        public double width { get; private set; }
        public double height { get; private set; }

        public Rectangle()
        {
            this.width = 0;
            this.height = 0;
        }

        public Rectangle(double w, double h)
        {
            this.width = w;
            this.height = h;
        }

        public override double Area()
        {
            return width * height;
        }

        public override string ToString()
        {
            return $"Тип: Прямоугольник, Ширина: {width}, Высота: {height}, Площадь: {Area()}";
        }

        public void Print()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
