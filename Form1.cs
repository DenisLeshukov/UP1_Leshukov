using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Shop_play_Leshukov
{
    public partial class Form1 : Form
    {
        private Dictionary<string, int> Basket = new Dictionary<string, int>();
        List<string> names = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }
        Shop pyaterochka = new Shop();


        

        

        private void Показать_повторно(object sender, EventArgs e)//Показать все товары в магазине +прибыль магазина элементы
        {
            showEl();
            Каталог_товаров.Items.Add($"Прибыль магазина {pyaterochka.GetProf()}");
        }

        private void Добвить_в_корзину(object sender, EventArgs e)//Продажа товара
        {

            if (textBox1.Text != "")//Проверка на пустое имя товара
            {
                string name = textBox1.Text;
                int count = Convert.ToInt32(numericUpDown1.Value);
                if (Basket.ContainsKey(name)) // проверка на то существует ли данный товар в корзине
                {
                    MessageBox.Show("Товар уже добавлен");
                }
                else
                {
                    if (pyaterochka.CheckforCount(name, count)) // проверка на количество идобавление в словарь
                    {
                        Корзина.Items.Add($"{name} {count}");
                        names.Add(name);
                        Basket.Add(name, count);
                    }
                }
            }
            else
            {
                MessageBox.Show("Введите имя товара");
            }
        }

        private void showEl()//Показать все товары в магазине
        {
            Каталог_товаров.Items.Clear();
            string q = pyaterochka.WriteAllProducts();
            string[] s = q.Split('\n');
            for (int i = 0; i < s.Length; i++)
            {
                Каталог_товаров.Items.Add(s[i]);
            }

            Каталог_товаров.Items.Add($"Прибыль магазина {pyaterochka.GetProf()}");//Вывод прибыли магазина
        }

        private void Добавить_товар(object sender, EventArgs e)//Добавить товар
        {
            if (textBox2.Text != "")
            {
                string name = textBox2.Text;
                int count = Convert.ToInt32(numericUpDown2.Value);
                int price = Convert.ToInt32(numericUpDown3.Value);
                if (pyaterochka.FindByName(name) == null)//Проверка на наличие товара
                {
                    pyaterochka.CreateProduct(name, price, count);//Создание продукта
                    pyaterochka.ProfitCount(price, count, 10);//Подсчёт трат на этот продукт
                    showEl();

                }
                else
                {
                    MessageBox.Show("Такой товар уже есть");
                }
            }
            else
            {
                MessageBox.Show("Введите имя товара");
            }
        }

        private void Продать_товары(object sender, EventArgs e) // Кнопка продажи товаров
        {
            for (int i = 0; i < names.Count; i++) // проходимся по количеству предметов в названиях 
            {
                pyaterochka.Sell(names[i], Basket[names[i]]);
            }
            Корзина.Items.Clear();
            showEl();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void практика1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Показать_практику1(object sender, EventArgs e) // показать практику 1
        {
            panel1.Visible = true;
        }

        private void Скрыть_практику1(object sender, EventArgs e) // скрыть практику 1
        {
            panel1.Visible = false;
        }
    }
}
