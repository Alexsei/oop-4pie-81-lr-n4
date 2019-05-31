using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ООП_4ПИЭ_81_ЛР_N4_Вопиловский
{
    class Shop
    {
        List<Toy> stock = new List<Toy>();  // список игрушек в магазине

        public Shop() { } //инициализация

        public int StockLength  // свойство количестево игрушек в магазине
        {
            get
            {
                return this.stock.Count;
            }
        }

        public void addStockItem(string name, string producer, int category, int price,  int markup,  int kZ, int year)
        {  // метод: добавить товар в магазин
            this.stock.Add(new Toy(this.stock.Count, name, producer, category, price, markup, kZ, year));
        }


        public void getStockItem(int i, int newJear, out int id, out string name, out string producer, out int category, 
                                        out int price, out int markup, out int markup2, out int year)
        {   //метода получить данные о товаре по ИД

            this.stock[i].Get(out int _id, out string _name, out string _producer, out int _category, 
                              out int _price, out int _markup, out int _kZ, out int _year);
            id = _id;
            name = _name;
            producer = _producer;
            category = _category;
            price = _price;
            markup = this.stock[i].newPrice();
            markup2 = this.stock[i].newPrice(newJear);
            year = _year;
        }
    }
}
