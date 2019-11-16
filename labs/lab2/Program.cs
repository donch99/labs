using System;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Донченко Мария ИУ5Ц-53Б";
            Console.WriteLine("\t\tРабота с классом геометрическая фигура\n"); 
            Rectangle rangle = new Rectangle(1, 3);
            Rect rect = new Rect(6);
            Circle c = new Circle(23);

            rangle.Print();
            rect.Print();
            c.Print();

            Console.ReadKey();
        }
    }
}
