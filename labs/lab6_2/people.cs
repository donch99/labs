using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6_2
{
    class people
    {
        public string name { get; private set; }
        public string surname { get; private set; }
        public string address { get; private set; }
        public double weight { get; private set; }

        [Attr("Описание для year")]
        public int year { get; private set; }

        public people()
        {
            this.name = "";
            this.surname = "";
            this.address = "";
            this.weight = 0;
            this.year = 0;
        }

        public people(string name, string surname,string address,double weight,int year)
        {
            this.name = name;
            this.surname = surname;
            this.address = address;
            this.weight = weight;
            this.year = year;
        }

        public override string ToString()
        {
            return "Имя: " + name +
                "\nФамилия: " + surname +
                "\nАдресс: " + address +
                "\nВес: " + weight + " кг" +
                "\nГод Рождения: " + year + " год";
        }

        public void Print()
        {
            Console.WriteLine(this.ToString());
        }

        public int Minus(int x, int y) { return x - y; }
    }
}
