using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ООП_4ПИЭ_81_ЛР_N4_Вопиловский
{
    public partial class Form1 : Form
    {
        Shop sh = new Shop(); // создание объекта магазин
        int zK = 2; // статический коэфициент повышения надбавки 
        public Form1()
        {
            InitializeComponent();
            initDefault();
            ListView();
        }

        private void initDefault()
        {
            sh.addStockItem("Кукла ЛОЛ", "meChina", 1, 500, 20, this.zK, 2015 );
            sh.addStockItem("Кукла Беби Борн", "Born", 6, 1500, 15, this.zK, 2017);
            sh.addStockItem("Супер машинка", "AvtoRun", 2, 1900, 13, this.zK, 2018);
            sh.addStockItem("Водяной пистолет", "АкваПлюс", 5, 300, 140, this.zK, 2019);
            sh.addStockItem("Конструктор", "ООО Умник", 8, 300, 25, this.zK, 2019);
            sh.addStockItem("Говоломка", "ОАО Секрет", 7, 500, 1, this.zK, 2018);
            sh.addStockItem("Краски", "Триколор", 6, 1900, 5, this.zK, 2017);
            sh.addStockItem("Пластелин", "Залип", 5, 900, 12, this.zK, 2018);
        }
        private void ListView() // вывод данных на экран
        {
            listStoreView.Items.Clear(); // очистить списока магазина
            for (int i = 0; i < sh.StockLength; i++)
            {
                sh.getStockItem(i,Convert.ToInt32(comboBox1.Text), out int id, out string name, out string producer, out int category, 
                                    out int price, out int markup, out int markup2, out int year);
                ListViewItem newAvto = new ListViewItem(Convert.ToString(id));
                newAvto.SubItems.Add(name);
                newAvto.SubItems.Add(producer);
                newAvto.SubItems.Add(Convert.ToString(category) + "+");
                newAvto.SubItems.Add(Convert.ToString(price+ markup2) + ".00");
                newAvto.SubItems.Add(Convert.ToString(year) + "г.");
                newAvto.SubItems.Add(Convert.ToString(price) + ".00");
                newAvto.SubItems.Add(Convert.ToString(markup) + ".00");
                newAvto.SubItems.Add(Convert.ToString(markup2) + ".00");
                listStoreView.Items.Add(newAvto);
            }
        }

        private void ComboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            ListView();
        }
    }
}
