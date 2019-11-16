using System;
using lab2;
using System.Collections;
using System.Collections.Generic;

namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Донченко Мария ИУ5Ц-53Б";
            Console.WriteLine("\t\t\tРабота с коллекциями");
            Rectangle rangle = new Rectangle(1, 3);
            Rect rect = new Rect(6);
            Circle c = new Circle(23);

            ArrayList arr = new ArrayList();

            arr.Add(c);
            arr.Add(rect);
            arr.Add(rangle);

            Console.WriteLine( "\nНеотсортированная коллекция ArrayList\n");
            for(int i = 0; i < arr.Count; i++)
                Console.WriteLine(arr[i]);

            arr.Sort();

            Console.WriteLine("\nОтсортированная коллекция ArrayList\n");
            for (int i = 0; i < arr.Count; i++)
                Console.WriteLine(arr[i]);

            List<geom_fig> list = new List<geom_fig>();

            list.Add(c);
            list.Add(rect);
            list.Add(rangle);

            Console.WriteLine("\nНеотсортированная коллекция List<geom_fig>\n");
            for (int i = 0; i < list.Count; i++)
                Console.WriteLine(arr[i]);

            list.Sort();

            Console.WriteLine("\nОтсортированная коллекция List<geom_fig>\n");
            for (int i = 0; i < list.Count; i++)
                Console.WriteLine(arr[i]);

            mList<geom_fig> mL = new mList<geom_fig>();

            mL.Add(c);
            mL.Add(rect);
            mL.Add(rangle);

            Console.WriteLine("\nНеотсортированная коллекция myList<geom_fig>\n");

            for(int i = 0; i < mL.Count; i++)
                Console.WriteLine(arr[i]);

            mL.Sort();

            Console.WriteLine("\nНтсортированная коллекция myList<geom_fig>\n");

            for (int i = 0; i < mL.Count; i++)
                Console.WriteLine(arr[i]);

            mStack<geom_fig> mstack = new mStack<geom_fig>();

            mstack.Push(rangle);
            mstack.Push(rect);
            mstack.Push(c);

            Console.WriteLine("\nСтек mStack<geom_fig> метод Push()\n");

            for (int i = 0; i < mstack.Count; i++)
                Console.WriteLine(arr[i]);


            Console.WriteLine("\nСтек mStack<geom_fig> метод Pop()\n");

            mstack.Pop();

            for (int i = 0; i < mstack.Count; i++)
                Console.WriteLine(arr[i]);

            SparseMatrix<geom_fig> matrix = new SparseMatrix<geom_fig>(3, 3);

            matrix[0, 1] = rangle;
            matrix[1, 0] = rect;
            matrix[1, 2] = c;

            Console.WriteLine("\n{0,70}", "Демонстрация SparseMatrix<geom_fig> без вывода площади фигуры");

            Console.WriteLine(matrix);
        }
    }
}
