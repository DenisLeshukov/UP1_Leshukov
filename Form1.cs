using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop_play_Leshukov
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Shop pyaterochka = new Shop();
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
        }
    }
}
