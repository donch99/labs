using System;

namespace lab2
{
    public class Circle : geom_fig, IPrint
    {
        double radius { get; set; }
        public Circle()
        {
            this.radius = 0;
        }
        public Circle(double r)
        {
            this.radius = r;
        }
        public override double Area()
        {
            return (Math.PI * Math.Pow(radius, 2));
        }
        public override string ToString()
        {
            return $"Тип: Круг, Радиус: {radius}, Площадь: {Area()}";
        }

        public void Print()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
