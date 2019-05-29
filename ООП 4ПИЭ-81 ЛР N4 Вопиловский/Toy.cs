using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ООП_4ПИЭ_81_ЛР_N4_Вопиловский
{
    class Toy : Goods  // класс Игрушка от базового класса Goods
    {
        public Toy (int id, string name, string producer, int category, int price): base (id, name, producer,  category,  price)
        {
            int markup; // ежегодный процент наценки за товар 
        }
    }
}
