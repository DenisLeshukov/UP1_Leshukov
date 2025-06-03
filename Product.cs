using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_play_Leshukov
{
    class Product
    {
        public decimal Price { get; set; }
        public string Name { get; set; }

        public Product(string Name, decimal Price)
        {
            this.Name = Name;
            this.Price = Price;
        }

<<<<<<< HEAD


        public string GetInfo()//Получение информации о продуктах
=======
        public string GetInfo()
>>>>>>> 7ea178c4040874ed38808f0754178368b47f1eda
        {
            return $"Наименование: {Name}; Цена: {Price} руб.";
        }
    }
}
