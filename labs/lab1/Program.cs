using System;

namespace lab1
{
    class Program
    {
        static double proverka_na_vvod()
        {
            while (true)
            {
                try
                {
                    return double.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Значение введено неверно, попробуйте снова!");
                }
            }
        }

        static double arg_convert_double(string s)
        {
            try
            {
                return double.Parse(s);
            }
            catch
            {
                Console.WriteLine("Аргумент коммандной строки получен не правильно!!!");
                return proverka_na_vvod();
            }
        }

        static void calc_this_uravnenie(double a,double b, double c)
        {
            double t1, t2, x1, x2, x3, x4;

            double d = Math.Pow(b, 2) - 4 * a * c;

            if (d >= 0 && a != 0 && b != 0)
            {
                t1 = (-b + Math.Sqrt(d)) / (2 * a);
                t2 = (-b - Math.Sqrt(d)) / (2 * a);

                Console.ForegroundColor = ConsoleColor.Red;
                if (t1 < 0 && t2 < 0)
                {
                    Console.WriteLine("\nКорней нет!");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    if (t1 >= 0 || t2>=0)
                    {
                        if(t1 >= 0)
                        {
                            x1 = Math.Sqrt(t1);
                            x2 = -Math.Sqrt(t1);
                            if (x1 == x2)
                                Console.WriteLine($"\nКорень уравнения: { x1 }\n");
                            else
                                Console.WriteLine($"\nКорень уравнения: { x1 }\nКорень уравнения: { x2 }\n");
                        }
                        if(t2 >= 0)
                        {
                            x3 = Math.Sqrt(t2);
                            x4 = -Math.Sqrt(t2); 
                            if (x3 == x4)
                                Console.WriteLine($"\nКорень уравнения: { x3 }\n");
                            else
                                Console.WriteLine($"\nКорень уравнения: { x3 }\nКорень уравнения: { x4 }\n");
                        }
                    }
                    Console.ResetColor();
                }
            }
            else if (a == 0 || b != 0)
            {
                if (c <= 0 && a > 0) 
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    x1 = Math.Sqrt(-c / b);
                    x2 = -Math.Sqrt(-c / b);
                    if (x1 == x2)
                        Console.WriteLine($"\nКорень уравнения: { x1 }\n");
                    else
                        Console.WriteLine($"\nКорень уравнения: { x1 }\nКорень уравнения: { x2 }\n");
                    Console.ResetColor();
                }
                else if (c >= 0 && a < 0) 
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    x1 = Math.Sqrt(-c / b);
                    x2 = -Math.Sqrt(-c / b);
                    if (x1 == x2)
                        Console.WriteLine($"\nКорень уравнения: { x1 }\n");
                    else
                        Console.WriteLine($"\nКорень уравнения: { x1 }\nКорень уравнения: { x2 }\n");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nКорней нет!");
                    Console.ResetColor();
                }
            }
            else if (b == 0 && a != 0)
            {
                if (c <= 0 && a > 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    x1 = Math.Sqrt(Math.Sqrt(-c / a));
                    x2 = -Math.Sqrt(Math.Sqrt(-c / a));
                    if (x1 == x2)
                        Console.WriteLine($"\nКорень уравнения: { x1 }\n");
                    else
                        Console.WriteLine($"\nКорень уравнения: { x1 }\nКорень уравнения: { x2 }\n");
                    Console.ResetColor();
                }
                else if (c >= 0 && a < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    x1 = Math.Sqrt(Math.Sqrt(-c / a));
                    x2 = -Math.Sqrt(Math.Sqrt(-c / a));
                    if (x1 == x2)
                        Console.WriteLine($"\nКорень уравнения: { x1 }\n");
                    else
                        Console.WriteLine($"\nКорень уравнения: { x1 }\nКорень уравнения: { x2 }\n");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nКорней нет!");
                    Console.ResetColor();
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nКорней нет!");
                Console.ResetColor();
            }
        }

        static void Main(string[] args)
        {
            Console.Title = "Донченко Мария ИУ5Ц-53Б";
            Console.WriteLine("\t\tРешение биквадратного уравнения\n");
            Console.WriteLine("ax^4+bx^2+c=0\n");

            double a, b, c;

            if (args.Length == 3 && args.Length != 0)
            {
                a = arg_convert_double(args[0]);
                b = arg_convert_double(args[1]);
                c = arg_convert_double(args[2]);
            }
            else
            {
                Console.Write("Введите аргумент а: ");
                a = proverka_na_vvod();
                Console.Write("Введите аргумент b: ");
                b = proverka_na_vvod();
                Console.Write("Введите аргумент c: ");
                c = proverka_na_vvod();
            }
            calc_this_uravnenie(a, b, c);
        }
    }
}
