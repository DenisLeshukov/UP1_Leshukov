using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
<<<<<<< HEAD
using System.Diagnostics;
=======
>>>>>>> 7ea178c4040874ed38808f0754178368b47f1eda
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
<<<<<<< HEAD
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
=======
>>>>>>> 7ea178c4040874ed38808f0754178368b47f1eda

namespace Shop_play_Leshukov
{
    public partial class Form1 : Form
    {
<<<<<<< HEAD
        private Dictionary<string, int> Basket = new Dictionary<string, int>();
        List<string> names = new List<string>();
=======
>>>>>>> 7ea178c4040874ed38808f0754178368b47f1eda
        public Form1()
        {
            InitializeComponent();
        }
        Shop pyaterochka = new Shop();
<<<<<<< HEAD


        

        

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
=======
        List<string> productText = new List<string>();

        private void button1_Click(object sender, EventArgs e)
        {
           
            pyaterochka.CreateProduct("Кола", 85, 200);
            pyaterochka.CreateProduct("Сок \"Добрый\"", 100, 10); List<string> podtit = pyaterochka.WriteAllProducts();
            
            foreach (var prod in podtit)
            {
                listBox1.Items.Add(prod);
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string text = "";
            
            pyaterochka.Sell("Сок \"Добрый\"", ref text);
            productText = pyaterochka.WriteAllProducts();
            listBox1.Items.Clear();
            foreach(var product in productText)
            {
                listBox1.Items.Add(product);
            }
            if (text != string.Empty)
                MessageBox.Show(text);
>>>>>>> 7ea178c4040874ed38808f0754178368b47f1eda
        }
    }
}
