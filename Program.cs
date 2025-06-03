using System;

namespace Cat_Leshukov
{
    class Program
    {
        static void Main(string[] args)
        {
            // обработчик исключений
            try
            {
                // Создаем объекты класса, вводим имя, вес кота
                Cat cat1 = new Cat(Console.ReadLine(), Convert.ToDouble(Console.ReadLine()));
                Cat cat2 = new Cat(Console.ReadLine(), Convert.ToDouble(Console.ReadLine()));

                //вывод веса и имени
                cat1.GetWeight();
                
                //вывод веса и имени
                cat2.GetWeight();
            }
            catch
            {
                Console.WriteLine("Введены неверные данные");
            }
           


        }
    }
}
