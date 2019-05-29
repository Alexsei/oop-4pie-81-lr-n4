using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ООП_4ПИЭ_81_ЛР_N4_Вопиловский
{
    class Shop
    {
        List<Goods> stock = new List<Goods>(); // вспомогательный класс: магазин
        List<Goods> basket = new List<Goods>();// вспомогательный класс: корзина
        List<Goods> order = new List<Goods>(); // вспомогательный класс: история покупок

        public Shop() { } //инициализация
        public int StockLength  // свойство количестево товаров в магазине
        {
            get
            {
                return this.stock.Count;
            }
        }
        public int BasketLength  // свойство количестево товаров в магазине
        {
            get
            {
                return this.basket.Count;
            }

        }
        public int OrderLength  // свойство количестево товаров в магазине
        {
            get
            {
                return this.order.Count;
            }

        }
        public int getStockSumma // сумма цен всех товаров в магазине;
        {
            get
            {
                int sum = 0;
                for (int i = 0; i < this.StockLength; i++)
                {
                    this.getStockItem(i, out int id, out string name, out string producer, out int category, out int price);
                    sum = sum + price;
                }
                return sum;
            }
        }
        public int getBasketSumma // сумма цен всех товаров в корзины;
        {
            get
            {
                int sum = 0;
                for (int i = 0; i < this.BasketLength; i++)
                {
                    this.getBasketItem(i, out int id, out string name, out string producer, out int category, out int price);
                    sum = sum + price;
                }
                return sum;
            }
        }
        public int getOrderSumma // сумма цен всех товаров в истории заказов;
        {
            get
            {
                int sum = 0;
                for (int i = 0; i < this.OrderLength; i++)
                {
                    this.getOrderItem(i, out int id, out string name, out string producer, out int category, out int price);
                    sum = sum + price;
                }
                return sum;
            }
        }

        public void basketClear() // очистить корзину
        {
            basket = new List<Goods>();
        }
        public void orderClear() // очистить историю 
        {
            order = new List<Goods>();
        }
        public void addStockItem(string name, string producer, int category, int price)
        {  // добавить товар в магазин
            this.stock.Add(new Goods(this.stock.Count, name, producer, category, price));
        }
        public void addStock(Goods newItem) // добавить товар в магазин объектом
        {
            newItem.Id = this.stock.Count;
            this.stock.Add(newItem);
        }
        public void addBasketItem(string name, string producer, int category, int price)
        {    // добавить товар в корзину
            this.basket.Add(new Goods(this.basket.Count, name, producer, category, price));
        }
        public void addOrderItem(string name, string producer, int category, int price)
        {   // добавить товар в историю
            this.order.Add(new Goods(this.order.Count, name, producer, category, price));
        }
        public void getStockItem(int i, out int id, out string name, out string producer, out int category, out int price)
        {   // получить данные о товаре по ИД
            this.stock[i].Get(out int _id, out string _name, out string _producer, out int _category, out int _price);
            id = _id;
            name = _name;
            producer = _producer;
            category = _category;
            price = _price;
        }
        public List<Goods> getStockFilter(int category) //получить отфильтрованный по категории список товаров
        {
            List<Goods> Filter = new List<Goods>();
            for (int i = 0; i < this.StockLength; i++)
            {
                this.getStockItem(i, out int _id, out string _name, out string _producer, out int _category, out int _price);
                if (category == _category)
                {
                    Filter.Add(new Goods(_id, _name, _producer, _category, _price));
                }
            }
            return Filter;
        }
        public int getStockCatItens(int catMin, int catMax) // сумма цен всех товаров в магазине;
        {
            int sum = 0;
            for (int i = 0; i < this.StockLength; i++)
            {
                this.getStockItem(i, out int id, out string name, out string producer, out int category, out int price);
                if ((catMin <= category) && (category <= catMax))
                {
                    sum++;
                }
            }
            Console.WriteLine(sum);
            return sum;
        }
        public void getBasketItem(int i, out int id, out string name, out string producer, out int category, out int price)
        {   // получить данные о товаре по ИД в корзине
            this.basket[i].Get(out int _id, out string _name, out string _producer, out int _category, out int _price);
            id = _id;
            name = _name;
            producer = _producer;
            category = _category;
            price = _price;
        }
        public void getOrderItem(int i, out int id, out string name, out string producer, out int category, out int price)
        {   // получить данные о товаре по ИД в истории
            this.order[i].Get(out int _id, out string _name, out string _producer, out int _category, out int _price);
            id = _id;
            name = _name;
            producer = _producer;
            category = _category;
            price = _price;
        }
    }
}
