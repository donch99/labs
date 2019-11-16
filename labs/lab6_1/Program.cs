using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6_1
{
    delegate int func(int a);
    class Program
    {
        static int factor(int a)
        {
            if (a > 0)
            {
                int res = 1;
                for (int i = 2; i <= a; i++)
                    res *= i;
                return res;
            }
            else
            {
                return 0;
            }
        }

        static int sum(int a)
        {
            if (a > 0)
            {
                int res = 1;
                for (int i = 2; i <= a; i++)
                    res += i;
                return res;
            }
            else
            {
                return 0;
            }
        }

        static void delfunc(string s, int a, func f)
        {
            Console.WriteLine("Число: " + a);
            Console.WriteLine(s + f(a));
            Console.WriteLine();
        }
        
        static void delfuncf(string s, int a, Func<int, int> f)
        {
            Console.WriteLine("Число: " + a);
            Console.WriteLine(s + f(a));
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            delfunc("Факториал: ", 5, factor);
            delfunc("Сумма: ", 5, sum);

            Console.WriteLine("Создание экземпляра делегата на основе лямбда-выражения");
            delfunc("Факториал: ", 6, (int a) => { return factor(a); });

            Console.WriteLine("Использование обощенного делегата Func<>");
            Func<int, int> f = sum;
            delfuncf("Сумма: ",6 , f);
        }
    }
}
