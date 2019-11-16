using System;
using System.Reflection;

namespace lab6_2
{
    class Program
    {
        static void PrintInfoAssembly()
        {
            Console.WriteLine("Информация о сборке: ");
            Assembly ass = Assembly.GetExecutingAssembly();
            Console.WriteLine("Имя проекта: " + ass.FullName);
            Console.WriteLine("Расположение файла: " + ass.Location);
        }
        static void PrintInfoClass()
        {
            people c1 = new people("Маша", "Донченко", "улица Бауманская д1", 55, 1998);
            Type t = c1.GetType();

            Console.WriteLine("Информация о классе:\n");

            Console.WriteLine("Конструкторы: ");

            foreach (var i in t.GetConstructors())
                Console.WriteLine(i);

            Console.WriteLine("\nСвойства: ");

            foreach (var i in t.GetProperties())
                Console.WriteLine(i);

            Console.WriteLine("\nМетоды: ");

            foreach (var i in t.GetMethods())
                Console.WriteLine(i);
        }

        public static bool GetPropertyAttribute(PropertyInfo checkType, Type attributeType, out object attribute)
        {
            bool Result = false;
            attribute = null;

            var isAttribute = checkType.GetCustomAttributes(attributeType, false);
            if (isAttribute.Length > 0)
            {
                Result = true;
                attribute = isAttribute[0];
            }

            return Result;
        }

        static void InfoAttrib()
        {
            Type t = typeof(people);
            Console.WriteLine("\nСвойства, помеченные атрибутом:");
            foreach (var x in t.GetProperties())
            {
                object attrObj;
                if (GetPropertyAttribute(x, typeof(Attr), out attrObj))
                {
                    Attr attr = attrObj as Attr;
                    Console.WriteLine(x.Name + " - " + attr.Description);
                }
            }
        }

        static void InvokeMemberInfo()
        {
            Type t = typeof(people);
            Console.WriteLine("\nВызов метода:");

            people c1 = (people)t.InvokeMember(null, BindingFlags.CreateInstance, null, null, new object[] { });

            object[] parameters = new object[] { 3, 2 };

            object Result = t.InvokeMember("Minus", BindingFlags.InvokeMethod, null, c1, parameters);
            Console.WriteLine("Minus(3,2) = {0}", Result);
        }

        static void Main(string[] args)
        {
            PrintInfoAssembly();
            PrintInfoClass();
            InfoAttrib();
            InvokeMemberInfo();
        }
    }
}
