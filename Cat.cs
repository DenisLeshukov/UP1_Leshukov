using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cat_Leshukov
{
    class Cat
    {
        private string name; // скрытое поле
        public string Name // свойство, реализуем инкапсуляцию!
        {
            // получение значения - просто возврат name
            get
            {
                return name;
            }
            // установка значения - используем проверку
            set
            {
                bool OnlyLetters = true;
                // ключ. слово value - это то, что хотят свойству присвоить
                foreach (var ch in value)
                {
                    if (!char.IsLetter(ch)) // проверка на то, что в слове все символы являются буквами
                    {
                        OnlyLetters = false;
                    }
                }
                

                if (OnlyLetters)
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine($"{value} - неправильное имя!!!");
                }
            }
        }


        private double weight;// скрытое поле
        public double Weight
        {
            get
            {
                return weight;
            }
            set
            {
                if (value <= 0 || value > 22)
                {
                    Console.WriteLine("Вес должен быть больше 0 и не более 22 кг.");
                }
                else
                {
                    weight = value;
                }
            }
        }
        // конструктор для создания объекта
        public Cat(string CatName, double WeightCat)
        {
            Name = CatName;
            Weight = WeightCat;
        }
        // Метод, который выводит сообщение
        public void Meow()
        {
            Console.WriteLine($"{name}: МЯЯЯУ!!!!");
        }
        public void GetWeight()
        {
            Console.WriteLine($"Вес кота {name} равен {weight}");
        }


    }
}
