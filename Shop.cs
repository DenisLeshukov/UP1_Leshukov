using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_play_Leshukov
{
    class Shop
    {
        private Dictionary<Product, int> products;

        public Shop()
        {
            products = new Dictionary<Product, int>();
        }

        public void AddProduct(Product product, int count)
        {
            products.Add(product,count);
        }

        public List<string> WriteAllProducts()
        {
            List<string> podtit = new List<string>();
            
            string title = "";
            foreach (var product in products)
            {
                podtit.Add(product.Key.GetInfo() + "Количество " + product.Value);
            }
            return podtit;
        }

        public void CreateProduct(string name, decimal price, int count)
        {
            products.Add(new Product(name, price), count);
        }

        public void Sell(Product product, ref string text)
        {
            if (products.ContainsKey(product))
            {
                if (products[product] == 0)
                {
                    text = "Нет в наличии";
                }
                else
                {
                    products[product]--;
                }
            }
            else
            {
                text = "Товар не найден";
            }
        }
        public void Sell(string ProductName, ref string text)
        {
            string t = "";
            Product ToSell = FindByName(ProductName);
            if (ToSell != null)
            {
                this.Sell(ToSell,ref t);
                text = t;
            }
            else
            {
                text = "Товар не найден";
            }
        }
        public Product FindByName(string name)
        {
            foreach (var product in products.Keys)
            {
                if (product.Name == name)
                {
                    return product;
                }
            }
            return null;
        }
    }
}
