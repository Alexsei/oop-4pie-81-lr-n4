using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ООП_4ПИЭ_81_ЛР_N4_Вопиловский
{
    class Goods
    {
        //Класс – товар в магазине игрушек.Известны наименование товара, возрастная категория, производитель, цена.
        protected int id;     // id товара
        protected string name;     // наименование товара
        protected string producer; // производитель
        protected int category;    // возврастная категория
        protected int price;       // цена товара

        public Goods(int id, string name, string producer, int category, int price)
        {   // инициализация
            this.id = id;
            this.name = name;
            this.producer = producer;
            this.category = category;
            this.price = price;
        }
        public int Id  // свойство id товара
        {
            set
            {
                this.id = value;
            }
            get
            {
                return this.id;
            }
        }

        public void Set(int id, string name, string producer, int category, int price)
        {       // метод для сохранения новых пораметров
            this.id = id;
            this.name = name;
            this.producer = producer;
            this.category = category;
            this.price = price;
        }

        public void Get(out int id, out string name, out string producer, out int category, out int price)
        {   // метод чтения параметров
            id = this.id;
            name = this.name;
            producer = this.producer;
            category = this.category;
            price = this.price;
        }

        public Goods Hybrid(Goods goods1, Goods goods2)
        {  // метод гибридизации товара из двух других:
           // При "сложении" наименование товара взять из первого аргумента, производителя из второго. 
           //Цена товара равна сумме цен, возрастная категория -максимальна для двух аргументов.
           //запросим параметры товаров
            goods1.Get(out int id1, out string name1, out string producer1, out int category1, out int price1);
            goods2.Get(out int id2, out string name2, out string producer2, out int category2, out int price2);
            int category3 = category2; // по умолчанию  новая категория равна категорию второго товара
            if (category1 > category2) // если категория первого товара больше категории второго товара
            {                          // то категория нового товара равна категории первого
                category3 = category1;
            }
            // создадим новый объект товара
            Goods goods3 = new Goods(0, name1, producer2, category3, (price1 + price2));
            return goods3; // возврат результата гибридизации
        }
    }
}
