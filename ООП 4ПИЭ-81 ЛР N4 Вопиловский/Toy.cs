using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ООП_4ПИЭ_81_ЛР_N4_Вопиловский
{
    class Toy : Goods  // класс Игрушка от базового класса Goods
    {
        int markup; // ежегодный процент наценки за товар
        int kZ;     // коэфициент увеличения наценки
        int year;   // год выпуска;

        // конструктор с параметрами для базового класса и производного
        public Toy (int id, string name, string producer, int category, int price, int markup, int kZ, int year) 
            : base (id, name, producer,  category,  price)
        {  // инициализация 
            this.markup = markup;
            this.kZ = kZ;
            this.year = year;
        }

        public void Set(int id, string name, string producer, int category, int price, int markup, int kZ, int year)
        {   // перегрузка метода: для сохранения новых пораметров
            this.id = id;
            this.name = name;
            this.producer = producer;
            this.category = category;
            this.price = price;
            this.markup = markup;
            this.kZ = kZ;
            this.year = year;
        }

        public void Get(out int id, out string name, out string producer, out int category, out int price, out int markup, out int kZ, out int year)
        {   // перегрузка метода: метод чтения параметров
            id = this.id;
            name = this.name;
            producer = this.producer;
            category = this.category;
            price = this.price;
            markup = this.markup;
            kZ = this.kZ;
            year = this.year;
        }
        public int newPrice()
        {   // расчет наценки за год;
            return (this.price * this.markup / 100);
        }

        public int newPrice(int newYear)
        {   // перегрузка метода: расчет наценки за на выбранный год

            if (newYear - this.year > 0)
            {
                return this.price * this.markup / 100 *
                    Convert.ToInt32( Math.Pow(this.kZ, (newYear - this.year - 1)));
            } else
            {
                return 0;
            }
        }
    }
}
